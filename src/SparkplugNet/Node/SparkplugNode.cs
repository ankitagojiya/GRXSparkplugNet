﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SparkplugNode.cs" company="Hämmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   A class that handles a Sparkplug node.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SparkplugNet.Node
{
    using System;
    using System.Collections.Concurrent;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using MQTTnet;
    using MQTTnet.Client;
    using MQTTnet.Client.Options;
    using MQTTnet.Formatter;
    using MQTTnet.Protocol;

    using SparkplugNet.Enumerations;

    /// <inheritdoc cref="SparkplugBase"/>
    /// <summary>
    /// A class that handles a Sparkplug node.
    /// </summary>
    /// <seealso cref="SparkplugBase"/>
    public class SparkplugNode : SparkplugBase
    {
        /// <summary>
        /// The will message.
        /// </summary>
        private MqttApplicationMessage? willMessage;

        /// <summary>
        /// The node online message.
        /// </summary>
        private MqttApplicationMessage? applicationOnlineMessage;

        /// <inheritdoc cref="SparkplugBase"/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SparkplugNode"/> class.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <param name="nameSpace">The namespace.</param>
        /// <seealso cref="SparkplugBase"/>
        public SparkplugNode(SparkplugVersion version, SparkplugNamespace nameSpace)
            : base(version, nameSpace)
        {
        }

        /// <summary>
        /// Gets the device states.
        /// </summary>
        public ConcurrentDictionary<string, SparkplugConnectionStatus> DeviceStates { get; } = new ConcurrentDictionary<string, SparkplugConnectionStatus>();

        /// <summary>
        /// Starts the Sparkplug node.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        /// <returns>A <see cref="Task"/> representing any asynchronous operation.</returns>
        public async Task Start(SparkplugNodeOptions options)
        {
            // Clear states
            this.DeviceStates.Clear();

            // Load messages
            this.LoadMessages(options);

            // Add handlers
            this.AddDisconnectedHandler(options);
            this.AddMessageReceivedHandler();

            // Connect, subscribe to incoming messages and send a state message
            await this.ConnectInternal(options);
            await this.SubscribeInternal(options);
            await this.PublishInternal(options);
        }

        /// <summary>
        /// Stops the Sparkplug node.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing any asynchronous operation.</returns>
        public async Task Stop()
        {
            await this.Client.DisconnectAsync();
        }

        /// <summary>
        /// Loads the messages used by the the Sparkplug application.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        private void LoadMessages(SparkplugNodeOptions options)
        {
            this.willMessage = this.MessageGenerator.CreateSparkplugMessage(
                this.Version,
                this.NameSpace,
                options.GroupIdentifier,
                SparkplugMessageType.NodeDeath,
                options.EdgeNodeIdentifier,
                null);

            this.applicationOnlineMessage = this.MessageGenerator.CreateSparkplugMessage(
                this.Version,
                this.NameSpace,
                options.GroupIdentifier,
                SparkplugMessageType.NodeBirth,
                options.EdgeNodeIdentifier,
                null);
        }

        /// <summary>
        /// Adds the disconnected handler and the reconnect functionality to the client.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        private void AddDisconnectedHandler(SparkplugNodeOptions options)
        {
            this.Client.UseDisconnectedHandler(
                async e =>
                    {
                        // Set all states to unknown as we disconnected
                        foreach (var deviceState in this.DeviceStates)
                        {
                            this.DeviceStates[deviceState.Key] = SparkplugConnectionStatus.Unknown;
                        }

                        // Wait until the disconnect interval is reached
                        await Task.Delay(options.ReconnectInterval);

                        // Connect, subscribe to incoming messages and send a state message
                        await this.ConnectInternal(options);
                        await this.SubscribeInternal(options);
                        await this.PublishInternal(options);
                    });
        }

        /// <summary>
        /// Adds the message received handler to handle incoming messages.
        /// </summary>
        private void AddMessageReceivedHandler()
        {
            this.Client.UseApplicationMessageReceivedHandler(e =>
            {
                // Todo: Parse client and device data here and update their states (Dictionaries here) based on the namespace
                Console.WriteLine("### RECEIVED APPLICATION MESSAGE ###");
                Console.WriteLine($"+ Topic = {e.ApplicationMessage.Topic}");
                Console.WriteLine($"+ Payload = {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                Console.WriteLine($"+ QoS = {e.ApplicationMessage.QualityOfServiceLevel}");
                Console.WriteLine($"+ Retain = {e.ApplicationMessage.Retain}");
                Console.WriteLine();
            });
        }

        /// <summary>
        /// Connects the Sparkplug node to the MQTT broker.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        /// <returns>A <see cref="Task"/> representing any asynchronous operation.</returns>
        private async Task ConnectInternal(SparkplugNodeOptions options)
        {
            options.CancellationToken ??= CancellationToken.None;

            var builder = new MqttClientOptionsBuilder()
                .WithClientId(options.ClientId)
                .WithCredentials(options.UserName, options.Password)
                .WithCleanSession(false)
                .WithProtocolVersion(MqttProtocolVersion.V311);

            if (options.UseTls)
            {
                builder.WithTls();
            }

            if (options.WebSocketParameters is null)
            {
                builder.WithTcpServer(options.BrokerAddress);
            }
            else
            {
                builder.WithWebSocketServer(options.BrokerAddress, options.WebSocketParameters);
            }

            if (options.ProxyOptions != null)
            {
                builder.WithProxy(
                    options.ProxyOptions.Address,
                    options.ProxyOptions.Username,
                    options.ProxyOptions.Password,
                    options.ProxyOptions.Domain,
                    options.ProxyOptions.BypassOnLocal);
            }

            if (this.willMessage != null)
            {
                builder.WithWillMessage(this.willMessage);
            }

            this.ClientOptions = builder.Build();

            await this.Client.ConnectAsync(this.ClientOptions, options.CancellationToken.Value);
        }

        /// <summary>
        /// Publishes data to the MQTT broker.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        /// <returns>A <see cref="Task"/> representing any asynchronous operation.</returns>
        private async Task PublishInternal(SparkplugNodeOptions options)
        {
            options.CancellationToken ??= CancellationToken.None;
            await this.Client.PublishAsync(this.applicationOnlineMessage, options.CancellationToken.Value);
        }

        /// <summary>
        /// Subscribes the client to the node subscribe topics.
        /// </summary>
        /// <param name="options">The configuration option.</param>
        /// <returns>A <see cref="Task"/> representing any asynchronous operation.</returns>
        private async Task SubscribeInternal(SparkplugNodeOptions options)
        {
            var nodeCommandSubscribeTopic = this.TopicGenerator.GetNodeCommandSubscribeTopic(this.Version, this.NameSpace, options.GroupIdentifier, options.EdgeNodeIdentifier);
            await this.Client.SubscribeAsync(nodeCommandSubscribeTopic, MqttQualityOfServiceLevel.AtLeastOnce);

            var deviceCommandSubscribeTopic = this.TopicGenerator.GetWildcardDeviceCommandSubscribeTopic(this.Version, this.NameSpace, options.GroupIdentifier, options.EdgeNodeIdentifier);
            await this.Client.SubscribeAsync(deviceCommandSubscribeTopic, MqttQualityOfServiceLevel.AtLeastOnce);

            var stateSubscribeTopic = this.TopicGenerator.GetStateSubscribeTopic(this.Version, options.ScadaHostIdentifier);
            await this.Client.SubscribeAsync(stateSubscribeTopic, MqttQualityOfServiceLevel.AtLeastOnce);
        }
    }
}