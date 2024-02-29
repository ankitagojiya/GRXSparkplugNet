// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SparkplugMessageGeneratorTest.cs" company="Hämmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   A class to test the <see cref="VersionB.PayloadConverter"/> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SparkplugNet.Tests.Payloads;

/// <summary>
/// A class to test the <see cref="VersionB.PayloadConverter"/> class.
/// </summary>
[TestClass]
public class SparkplugPayloadConverterTestVersionB
{
    /// <summary>
    /// Tests the Sparkplug payload converter for converting a version B payload from Proto.
    /// </summary>
    [TestMethod]
    public void TestConvertVersionBPayloadFromProto()
    {
        var dateTime = new DateTimeOffset(2021, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime2 = new DateTimeOffset(2022, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime3 = new DateTimeOffset(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime4 = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var bodyData = new byte[] { 1, 2, 3, 4 };
        var metrics = new List<VersionBProtoBufPayload.Metric>
        {
            new()
            {
                Name = "Test1",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 1,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int8,
                IntValue = 1
            },
            new()
            {
                Name = "Test2",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 2,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int16,
                IntValue = 2
            },
            new()
            {
                Name = "Test3",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 3,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int32,
                IntValue = 3
            },
            new()
            {
                Name = "Test4",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 4,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int64,
                LongValue = 4
            },
            new()
            {
                Name = "Test5",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 5,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt8,
                IntValue = 5
            },
            new()
            {
                Name = "Test6",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 6,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt16,
                IntValue = 6
            },
            new()
            {
                Name = "Test7",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 7,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt32,
                LongValue = 7
            },
            new()
            {
                Name = "Test8",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 8,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt64,
                LongValue = 8
            },
            new()
            {
                Name = "Test9",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 9,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Float,
                FloatValue = 9
            },
            new()
            {
                Name = "Test10",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 10,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Double,
                DoubleValue = 10
            },
            new()
            {
                Name = "Test11",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 11,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Boolean,
                BooleanValue = true
            },
            new()
            {
                Name = "Test12",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 12,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.String,
                StringValue = "12"
            },
            new()
            {
                Name = "Test13",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 13,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.DateTime,
                LongValue = 13
            },
            new()
            {
                Name = "Test13",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 13,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.DateTime,
                LongValue = 13
            },
            new()
            {
                Name = "Test14",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 14,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Text,
                StringValue = "14"
            },
            new()
            {
                Name = "Test15",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 15,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Text,
                StringValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            },
            new()
            {
                Name = "Test16",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 16,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.DataSet,
                DataSetValue = new VersionBProtoBufPayload.DataSet
                {
                    Columns = ["Test1", "Test2"],
                    NumberOfColumns = 2,
                    Rows =
                    [
                        new VersionBProtoBufPayload.DataSet.Row
                        {
                            Elements =
                            [
                                new()
                                {
                                    IntValue = 1
                                },
                                new()
                                {
                                    FloatValue = 2
                                }
                            ]
                        }
                    ],
                    Types = [1, 9]
                }
            },
            new()
            {
                Name = "Test17",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 17,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Bytes,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test18",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 18,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                MetaData = new VersionBProtoBufPayload.MetaData
                {
                    ContentType = "application/json",
                    Description = "Test",
                    FileName = "Test.json",
                    FileType = "json",
                    IsMultiPart = true,
                    Md5 = "md5",
                    Seq = 1,
                    Size = 1
                },
                DataType = (uint?)VersionBData.DataType.File,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test19",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 19,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Template,
                TemplateValue = new VersionBProtoBufPayload.Template
                {
                    IsDefinition = true,
                    Version = "1.0",
                    TemplateRef = "TestRef1",
                    Parameters =
                    [
                        new()
                        {
                            Name = "Test1",
                            DataType = (uint?)VersionBData.DataType.Int8,
                            IntValue = 1
                        },
                        new()
                        {
                            DataType = (uint?)VersionBData.DataType.Float,
                            Name = "Test2",
                            FloatValue = 2
                        }
                    ],
                    Metrics =
                    [
                        new()
                        {
                            Name = "Test1",
                            Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                            Alias = 1,
                            IsHistorical = true,
                            IsTransient = true,
                            IsNull = true,
                            DataType = (uint?)VersionBData.DataType.Int16,
                            IntValue = 1
                        },
                        new()
                        {
                            Name = "Test2",
                            Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                            Alias = 2,
                            IsHistorical = true,
                            IsTransient = true,
                            IsNull = true,
                            DataType = (uint?)VersionBData.DataType.Double,
                            DoubleValue = 1
                        }
                    ]
                }
            },
            new()
            {
                Name = "Test20",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 20,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.PropertySet,
                PropertySetValue = new VersionBProtoBufPayload.PropertySet
                {
                    Keys = ["Test1", "Test2"],
                    Values =
                    [
                        new()
                        {
                            IsNull = true,
                            DataType = (uint?)VersionBData.DataType.Int8,
                            IntValue = 1
                        },
                        new()
                        {
                            IsNull = true,
                            DataType = (uint?)VersionBData.DataType.Int64,
                            LongValue = 2
                        }
                    ]
                }
            },
            // Todo: How to handle this?!
            //new()
            //{
            //    Name = "Test21",
            //    Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
            //    Alias = 21,
            //    IsHistorical = true,
            //    IsTransient = true,
            //    IsNull = true,
            //    DataType = (uint?)VersionBData.DataType.PropertySetList,
            //    PropertySetListValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            //},
            new()
            {
                Name = "Test22",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 22,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int8Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test23",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 23,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int16Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test24",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 24,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int32Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test25",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 25,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.Int64Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test26",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 26,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt8Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test27",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 27,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt16Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test28",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 28,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt32Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test29",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 29,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.UInt64Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test30",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 30,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.FloatArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test31",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 31,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.DoubleArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test32",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 32,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.BooleanArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test33",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 33,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.StringArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test34",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 34,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBData.DataType.DateTimeArray,
                BytesValue = [1, 2, 3, 4]
            }
        };
        var convertedMetrics = new List<VersionBData.Metric>
        {
            new("Test1", VersionBData.DataType.Int8, (sbyte)1, dateTime2)
            {
                Alias = 1,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test2", VersionBData.DataType.Int16, (short)2, dateTime2)
            {
                Alias = 2,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test3", VersionBData.DataType.Int32, (int)3, dateTime2)
            {
                Alias = 3,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test4", VersionBData.DataType.Int64, (long)4, dateTime2)
            {
                Alias = 4,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test5", VersionBData.DataType.UInt8, (byte)5, dateTime2)
            {
                Alias = 5,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test6", VersionBData.DataType.UInt16, (ushort)6, dateTime2)
            {
                Alias = 6,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test7", VersionBData.DataType.UInt32, (uint)7, dateTime2)
            {
                Alias = 7,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test8", VersionBData.DataType.UInt64, (ulong)8, dateTime2)
            {
                Alias = 8,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test9", VersionBData.DataType.Float, 9f, dateTime2)
            {
                Alias = 9,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test10", VersionBData.DataType.Double, 10.0, dateTime2)
            {
                Alias = 10,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test11", VersionBData.DataType.Boolean, true, dateTime2)
            {
                Alias = 11,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test12", VersionBData.DataType.String, "12", dateTime2)
            {
                Alias = 12,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test13", VersionBData.DataType.DateTime, dateTime2, dateTime2)
            {
                Alias = 13,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test14", VersionBData.DataType.Text, "14", dateTime2)
            {
                Alias = 14,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test15", VersionBData.DataType.Uuid, "c609f36e-92f9-4103-92f0-bf9d95c18be9", dateTime2)
            {
                Alias = 15,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test16", VersionBData.DataType.DataSet, new VersionBData.DataSet
                {
                    Columns = ["Test1", "Test2"],
                    NumberOfColumns = 2,
                    Rows =
                    [
                        new VersionBData.Row
                        {
                            Elements =
                            [
                                new(VersionBData.DataType.Int16, 1)
                                {
                                },
                                new(VersionBData.DataType.Float, 2.0f)
                                {
                                }
                            ]
                        }
                    ],
                    Types = [1, 9]
                }, dateTime2)
            {
                Alias = 16,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test17", VersionBData.DataType.Bytes, new byte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 17,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test18", VersionBData.DataType.File, new byte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 18,
                IsHistorical = true,
                IsTransient = true,
                MetaData = new VersionBData.MetaData
                {
                    ContentType = "application/json",
                    Description = "Test",
                    FileName = "Test.json",
                    FileType = "json",
                    IsMultiPart = true,
                    Md5 = "md5",
                    Seq = 1,
                    Size = 1
                }
            },
            new("Test19", VersionBData.DataType.Template,
                new VersionBData.Template
                {
                    IsDefinition = true,
                    Version = "1.0",
                    TemplateRef = "TestRef1",
                    Parameters =
                    [
                        new("Test1", VersionBData.DataType.Int8, 1)
                        {
                        },
                        new("Test2", VersionBData.DataType.Float, 2.0f)
                        {
                        }
                    ],
                    Metrics =
                    [
                        new("Test1", VersionBData.DataType.Int16, 1, dateTime2)
                        {
                            Alias = 1,
                            IsHistorical = true,
                            IsTransient = true
                        },
                        new("Test2", VersionBData.DataType.Double, 2.0, dateTime2)
                        {
                            Alias = 2,
                            IsHistorical = true,
                            IsTransient = true
                        }
                    ]
                }, dateTime2)
            {
                Alias = 19,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test20", VersionBData.DataType.PropertySet, new VersionBData.PropertySet
                {
                    Keys = ["Test1", "Test2"],
                    Values =
                    [
                        new(VersionBData.DataType.Int8, 1)
                        {
                        },
                        new(VersionBData.DataType.Int64, (long)2)
                        {
                        }
                    ]
                }, dateTime2)
            {
                Alias = 20,
                IsHistorical = true,
                IsTransient = true
            },
            // Todo: How to handle this?!
            //new()
            //{
            //    Name = "Test21",
            //    Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
            //    Alias = 21,
            //    IsHistorical = true,
            //    IsTransient = true,
            //    IsNull = true,
            //    DataType = VersionBData.DataType.PropertySetList,
            //    PropertySetListValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            //},
            new("Test22", VersionBData.DataType.Int8Array, new sbyte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 22,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test23", VersionBData.DataType.Int16Array, new short[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 23,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test24", VersionBData.DataType.Int32Array, new int[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 24,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test25", VersionBData.DataType.Int64Array, new long[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 25,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test26", VersionBData.DataType.UInt8Array, new byte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 26,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test27", VersionBData.DataType.UInt16Array, new ushort[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 27,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test28", VersionBData.DataType.UInt32Array, new uint[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 28,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test29", VersionBData.DataType.UInt64Array, new ulong[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 29,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test30", VersionBData.DataType.FloatArray, new float[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 30,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test31", VersionBData.DataType.DoubleArray, new double[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 31,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test32", VersionBData.DataType.BooleanArray, new bool[] { true, false, true, false }, dateTime2)
            {
                Alias = 32,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test33", VersionBData.DataType.StringArray, new string[] { "1", "2", "3", "4" }, dateTime2)
            {
                Alias = 33,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test34", VersionBData.DataType.DateTimeArray, new DateTimeOffset[] { dateTime, dateTime2, dateTime3, dateTime4 }, dateTime2)
            {
                Alias = 34,
                IsHistorical = true,
                IsTransient = true
            }
        };
        var oldPayload = new VersionBProtoBufPayload
        {
            Body = bodyData,
            Timestamp = (ulong)dateTime.ToUnixTimeMilliseconds(),
            Seq = 1,
            Uuid = "477a41e5-f0ba-4b98-9522-95d44861d993",
            Metrics = metrics
        };
        var payload = VersionB.PayloadConverter.ConvertVersionBPayload(oldPayload);
        Assert.IsNotNull(payload);
        CollectionAssert.AreEqual(bodyData, payload.Body);
        Assert.AreEqual((ulong)dateTime.ToUnixTimeMilliseconds(), payload.Timestamp);
        Assert.AreEqual((ulong)1, payload.Seq);
        Assert.AreEqual("477a41e5-f0ba-4b98-9522-95d44861d993", payload.Uuid);
        Assert.AreEqual(convertedMetrics.Count, payload.Metrics.Count);

        var count = 0;

        foreach (var metric in payload.Metrics)
        {
            MetricEquals(convertedMetrics[count++], metric);
        }
    }

    /// <summary>
    /// Tests the Sparkplug payload converter for converting a version B payload to Proto.
    /// </summary>
    [TestMethod]
    public void TestConvertVersionBPayloadToProto()
    {
        var dateTime = new DateTimeOffset(2021, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime2 = new DateTimeOffset(2022, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime3 = new DateTimeOffset(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var dateTime4 = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var bodyData = new byte[] { 1, 2, 3, 4 };
        var metrics = new List<VersionBData.Metric>
        {
            new("Test1", VersionBData.DataType.Int8, (sbyte)1, dateTime2)
            {
                Alias = 1,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test2", VersionBData.DataType.Int16, (short)2, dateTime2)
            {
                Alias = 2,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test3", VersionBData.DataType.Int32, 3, dateTime2)
            {
                Alias = 3,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test4", VersionBData.DataType.Int64, (long)4, dateTime2)
            {
                Alias = 4,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test5", VersionBData.DataType.UInt8, (byte)5, dateTime2)
            {
                Alias = 5,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test6", VersionBData.DataType.UInt16, (ushort)6, dateTime2)
            {
                Alias = 6,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test7", VersionBData.DataType.UInt32, (uint)7, dateTime2)
            {
                Alias = 7,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test8", VersionBData.DataType.UInt64, (ulong)8, dateTime2)
            {
                Alias = 8,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test9", VersionBData.DataType.Float, 9.0f, dateTime2)
            {
                Alias = 9,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test10", VersionBData.DataType.Double, 10.0, dateTime2)
            {
                Alias = 10,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test11", VersionBData.DataType.Boolean, true, dateTime2)
            {
                Alias = 11,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test12", VersionBData.DataType.String, "12", dateTime2)
            {
                Alias = 12,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test13", VersionBData.DataType.DateTime, dateTime2, dateTime2)
            {
                Alias = 13,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test14", VersionBData.DataType.Text, "14", dateTime2)
            {
                Alias = 14,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test15", VersionBData.DataType.Text, "c609f36e-92f9-4103-92f0-bf9d95c18be9", dateTime2)
            {
                Alias = 15,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test16", VersionBData.DataType.DataSet, new VersionBData.DataSet
                {
                    Columns = ["Test1", "Test2"],
                    NumberOfColumns = 2,
                    Rows =
                    [
                        new VersionBData.Row
                        {
                            Elements =
                            [
                                new(VersionBData.DataType.Int16, 1)
                                {
                                },
                                new(VersionBData.DataType.Float, 2.0f)
                                {
                                }
                            ]
                        }
                    ],
                    Types = [1, 9]
                }, dateTime2)
            {
                Alias = 16,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test17", VersionBData.DataType.Bytes, new byte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 17,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test18", VersionBData.DataType.File, new byte[] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 18,
                IsHistorical = true,
                IsTransient = true,
                MetaData = new VersionBData.MetaData
                {
                    ContentType = "application/json",
                    Description = "Test",
                    FileName = "Test.json",
                    FileType = "json",
                    IsMultiPart = true,
                    Md5 = "md5",
                    Seq = 1,
                    Size = 1
                }
            },
            new("Test19", VersionBData.DataType.Template, new VersionBData.Template
                {
                    IsDefinition = true,
                    Version = "1.0",
                    TemplateRef = "TestRef1",
                    Parameters =
                    [
                        new("Test1", VersionBData.DataType.Int8, (sbyte)1)
                        {
                        },
                        new("Test2", VersionBData.DataType.Float, 2.0f)
                        {
                        }
                    ],
                    Metrics =
                    [
                        new("Test1", VersionBData.DataType.Int16, (short)1)
                        {
                            Alias = 1,
                            IsHistorical = true,
                            IsTransient = true
                        },
                        new("Test2", VersionBData.DataType.Double, 2.0)
                        {
                            Alias = 2,
                            IsHistorical = true,
                            IsTransient = true
                        }
                    ]
                }, dateTime2)
            {
                Alias = 19,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test20", VersionBData.DataType.PropertySet, new VersionBData.PropertySet
                {
                    Keys = ["Test1", "Test2"],
                    Values =
                    [
                        new(VersionBData.DataType.Int8, (sbyte)1)
                        {
                        },
                        new(VersionBData.DataType.Int64, (long)2)
                        {
                        }
                    ]
                }, dateTime2)
            {
                Alias = 20,
                IsHistorical = true,
                IsTransient = true
            },
            // Todo: How to handle this?!
            //new()
            //{
            //    Name = "Test21",
            //    Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
            //    Alias = 21,
            //    IsHistorical = true,
            //    IsTransient = true,
            //    IsNull = true,
            //    DataType = VersionBData.DataType.PropertySetList,
            //    PropertySetListValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            //},
            new("Test22", VersionBData.DataType.Int8Array, new sbyte [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 22,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test23", VersionBData.DataType.Int16Array, new short [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 23,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test24", VersionBData.DataType.Int32Array, new int [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 24,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test25", VersionBData.DataType.Int64Array, new long [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 25,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test26", VersionBData.DataType.UInt8Array, new byte [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 26,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test27", VersionBData.DataType.UInt16Array, new ushort [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 27,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test28", VersionBData.DataType.UInt32Array, new uint [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 28,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test29", VersionBData.DataType.UInt64Array, new ulong [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 29,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test30", VersionBData.DataType.FloatArray, new float [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 30,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test31", VersionBData.DataType.DoubleArray, new double [] { 1, 2, 3, 4 }, dateTime2)
            {
                Alias = 31,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test32", VersionBData.DataType.BooleanArray, new bool [] { true, false, true, false }, dateTime2)
            {
                Alias = 32,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test33", VersionBData.DataType.StringArray, new string [] { "1", "2", "3", "4" }, dateTime2)
            {
                Alias = 33,
                IsHistorical = true,
                IsTransient = true
            },
            new("Test34", VersionBData.DataType.DateTimeArray, new DateTimeOffset [] { dateTime, dateTime2, dateTime3, dateTime4 }, dateTime2)
            {
                Alias = 34,
                IsHistorical = true,
                IsTransient = true
            }
        };
        var convertedMetrics = new List<VersionBProtoBufPayload.Metric>
        {
            new()
            {
                Name = "Test1",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 1,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int8,
                IntValue = 1
            },
            new()
            {
                Name = "Test2",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 2,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int16,
                IntValue = 2
            },
            new()
            {
                Name = "Test3",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 3,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int32,
                IntValue = 3
            },
            new()
            {
                Name = "Test4",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 4,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int64,
                LongValue = 4
            },
            new()
            {
                Name = "Test5",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 5,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt8,
                IntValue = 5
            },
            new()
            {
                Name = "Test6",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 6,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt16,
                IntValue = 6
            },
            new()
            {
                Name = "Test7",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 7,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt32,
                LongValue = 7
            },
            new()
            {
                Name = "Test8",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 8,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt64,
                LongValue = 8
            },
            new()
            {
                Name = "Test9",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 9,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Float,
                FloatValue = 9
            },
            new()
            {
                Name = "Test10",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 10,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Double,
                DoubleValue = 10
            },
            new()
            {
                Name = "Test11",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 11,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Boolean,
                BooleanValue = true
            },
            new()
            {
                Name = "Test12",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 12,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.String,
                StringValue = "12"
            },
            new()
            {
                Name = "Test13",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 13,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.DateTime,
                LongValue = 13
            },
            new()
            {
                Name = "Test13",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 13,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.DateTime,
                LongValue = 13
            },
            new()
            {
                Name = "Test14",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 14,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Text,
                StringValue = "14"
            },
            new()
            {
                Name = "Test15",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 15,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Text,
                StringValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            },
            new()
            {
                Name = "Test16",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 16,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.DataSet,
                DataSetValue = new VersionBProtoBufPayload.DataSet
                {
                    Columns = ["Test1", "Test2"],
                    NumberOfColumns = 2,
                    Rows =
                    [
                        new VersionBProtoBufPayload.DataSet.Row
                        {
                            Elements =
                            [
                                new()
                                {
                                    IntValue = 1
                                },
                                new()
                                {
                                    FloatValue = 2
                                }
                            ]
                        }
                    ],
                    Types = [1, 9]
                }
            },
            new()
            {
                Name = "Test17",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 17,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Bytes,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test18",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 18,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                MetaData = new VersionBProtoBufPayload.MetaData
                {
                    ContentType = "application/json",
                    Description = "Test",
                    FileName = "Test.json",
                    FileType = "json",
                    IsMultiPart = true,
                    Md5 = "md5",
                    Seq = 1,
                    Size = 1
                },
                DataType = (uint?)VersionBProtoBuf.DataType.File,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test19",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 19,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Template,
                TemplateValue = new VersionBProtoBufPayload.Template
                {
                    IsDefinition = true,
                    Version = "1.0",
                    TemplateRef = "TestRef1",
                    Parameters =
                    [
                        new()
                        {
                            Name = "Test1",
                            DataType = (uint?)VersionBProtoBuf.DataType.Int8,
                            IntValue = 1
                        },
                        new()
                        {
                            DataType = (uint?)VersionBProtoBuf.DataType.Float,
                            Name = "Test2",
                            FloatValue = 2
                        }
                    ],
                    Metrics =
                    [
                        new()
                        {
                            Name = "Test1",
                            Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                            Alias = 1,
                            IsHistorical = true,
                            IsTransient = true,
                            IsNull = true,
                            DataType = (uint?)VersionBProtoBuf.DataType.Int16,
                            IntValue = 1
                        },
                        new()
                        {
                            Name = "Test2",
                            Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                            Alias = 2,
                            IsHistorical = true,
                            IsTransient = true,
                            IsNull = true,
                            DataType = (uint?)VersionBProtoBuf.DataType.Double,
                            DoubleValue = 1
                        }
                    ]
                }
            },
            new()
            {
                Name = "Test20",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 20,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.PropertySet,
                PropertySetValue = new VersionBProtoBufPayload.PropertySet
                {
                    Keys = ["Test1", "Test2"],
                    Values =
                    [
                        new()
                        {
                            IsNull = true,
                            DataType = (uint?)VersionBProtoBuf.DataType.Int8,
                            IntValue = 1
                        },
                        new()
                        {
                            IsNull = true,
                            DataType = (uint?)VersionBProtoBuf.DataType.Int64,
                            LongValue = 2
                        }
                    ]
                }
            },
            // Todo: How to handle this?!
            //new()
            //{
            //    Name = "Test21",
            //    Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
            //    Alias = 21,
            //    IsHistorical = true,
            //    IsTransient = true,
            //    IsNull = true,
            //    DataType = (uint?)VersionBProtoBuf.DataType.PropertySetList,
            //    PropertySetListValue = "c609f36e-92f9-4103-92f0-bf9d95c18be9"
            //},
            new()
            {
                Name = "Test22",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 22,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int8Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test23",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 23,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int16Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test24",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 24,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int32Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test25",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 25,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.Int64Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test26",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 26,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt8Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test27",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 27,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt16Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test28",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 28,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt32Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test29",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 29,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.UInt64Array,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test30",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 30,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.FloatArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test31",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 31,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.DoubleArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test32",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 32,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.BooleanArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test33",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 33,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.StringArray,
                BytesValue = [1, 2, 3, 4]
            },
            new()
            {
                Name = "Test34",
                Timestamp = (ulong)dateTime2.ToUnixTimeMilliseconds(),
                Alias = 34,
                IsHistorical = true,
                IsTransient = true,
                IsNull = true,
                DataType = (uint?)VersionBProtoBuf.DataType.DateTimeArray,
                BytesValue = [1, 2, 3, 4]
            }
        };
        var oldPayload = new VersionBData.Payload
        {
            Body = bodyData,
            Timestamp = (ulong)dateTime.ToUnixTimeMilliseconds(),
            Seq = 1,
            Uuid = "477a41e5-f0ba-4b98-9522-95d44861d993",
            Metrics = metrics
        };
        var payload = VersionB.PayloadConverter.ConvertVersionBPayload(oldPayload);
        Assert.IsNotNull(payload);
        CollectionAssert.AreEqual(bodyData, payload.Body);
        Assert.AreEqual((ulong)dateTime.ToUnixTimeMilliseconds(), payload.Timestamp);
        Assert.AreEqual((ulong)1, payload.Seq);
        Assert.AreEqual("477a41e5-f0ba-4b98-9522-95d44861d993", payload.Uuid);
        Assert.AreEqual(convertedMetrics.Count, payload.Metrics.Count);

        var count = 0;

        foreach (var metric in payload.Metrics)
        {
            MetricEquals(convertedMetrics[count++], metric);
        }
    }

    /// <summary>
    /// Tests the two given metrics for equality.
    /// </summary>
    /// <param name="expectedMetric">The expected metric.</param>
    /// <param name="newMetric">The new metric.</param>
    private static void MetricEquals(VersionBData.Metric expectedMetric, VersionBData.Metric newMetric)
    {
        Assert.AreEqual(expectedMetric.Alias, newMetric.Alias);
        Assert.AreEqual(expectedMetric.Value, newMetric.Value);
        Assert.AreEqual(expectedMetric.DataType, newMetric.DataType);
        Assert.AreEqual(expectedMetric.IsHistorical, newMetric.IsHistorical);
        Assert.AreEqual(expectedMetric.IsNull, newMetric.IsNull);
        Assert.AreEqual(expectedMetric.IsTransient, newMetric.IsTransient);
        MetaDataEquals(expectedMetric.MetaData, newMetric.MetaData);
        Assert.AreEqual(expectedMetric.Name, newMetric.Name);
        Assert.AreEqual(expectedMetric.Timestamp, newMetric.Timestamp);
    }

    /// <summary>
    /// Tests the two given data sets for equality.
    /// </summary>
    /// <param name="expectedDataSet">The expected data set.</param>
    /// <param name="newDataSet">The new data set.</param>
    private static void DataSetEquals(VersionBData.DataSet? expectedDataSet, VersionBData.DataSet? newDataSet)
    {
        if (expectedDataSet is not null && newDataSet is not null)
        {
            CollectionAssert.AreEqual(expectedDataSet.Columns, newDataSet.Columns);
            Assert.AreEqual(expectedDataSet.NumberOfColumns, newDataSet.NumberOfColumns);

            // Check the rows.
            var rowIndex = 0;

            foreach (var row in newDataSet.Rows)
            {
                var expectedRow = expectedDataSet.Rows[rowIndex];
                var elementIndex = 0;

                // Check the elements in the row.
                foreach (var element in row.Elements)
                {
                    var expectedElement = expectedRow.Elements[elementIndex];
                    DataSetValueEquals(expectedElement, element);
                    elementIndex++;
                }

                rowIndex++;
            }

            CollectionAssert.AreEqual(expectedDataSet.Types, newDataSet.Types);
        }
        else if (expectedDataSet is null && newDataSet is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The data set values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given data set values for equality.
    /// </summary>
    /// <param name="expectedDataSetValue">The expected data set value.</param>
    /// <param name="newDataSetValue">The new data set value.</param>
    private static void DataSetValueEquals(VersionBData.DataSetValue expectedDataSetValue, VersionBData.DataSetValue newDataSetValue)
    {
        Assert.AreEqual(expectedDataSetValue.DataType, newDataSetValue.DataType);
        Assert.AreEqual(expectedDataSetValue.Value, newDataSetValue.Value);
    }

    /// <summary>
    /// Tests the two given meta data for equality.
    /// </summary>
    /// <param name="expectedMetaData">The expected meta data.</param>
    /// <param name="newMetaData">The new meta data.</param>
    private static void MetaDataEquals(VersionBData.MetaData? expectedMetaData, VersionBData.MetaData? newMetaData)
    {
        if (expectedMetaData is not null && newMetaData is not null)
        {
            Assert.AreEqual(expectedMetaData.IsMultiPart, newMetaData.IsMultiPart);
            Assert.AreEqual(expectedMetaData.ContentType, newMetaData.ContentType);
            Assert.AreEqual(expectedMetaData.Size, newMetaData.Size);
            Assert.AreEqual(expectedMetaData.Seq, newMetaData.Seq);
            Assert.AreEqual(expectedMetaData.FileName, newMetaData.FileName);
            Assert.AreEqual(expectedMetaData.FileType, newMetaData.FileType);
            Assert.AreEqual(expectedMetaData.Md5, newMetaData.Md5);
            Assert.AreEqual(expectedMetaData.Description, newMetaData.Description);
        }
        else if (expectedMetaData is null && newMetaData is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The meta data values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given property sets for equality.
    /// </summary>
    /// <param name="expectedPropertySetValue">The expected property set.</param>
    /// <param name="newPropertySetValue">The new property set.</param>
    private static void PropertySetValueEquals(VersionBData.PropertySet? expectedPropertySetValue, VersionBData.PropertySet? newPropertySetValue)
    {
        if (expectedPropertySetValue is not null && newPropertySetValue is not null)
        {
            CollectionAssert.AreEqual(expectedPropertySetValue.Keys, newPropertySetValue.Keys);

            var propertyIndex = 0;

            foreach (var propertyValue in newPropertySetValue.Values)
            {
                var expectedPropertyValue = expectedPropertySetValue.Values[propertyIndex];
                PropertyValueEquals(expectedPropertyValue, propertyValue);
                propertyIndex++;
            }
        }
        else if (expectedPropertySetValue is null && newPropertySetValue is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The property set values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given property values for equality.
    /// </summary>
    /// <param name="expectedDataSetValue">The expected property value.</param>
    /// <param name="newDataSetValue">The new property value.</param>
    private static void PropertyValueEquals(VersionBData.PropertyValue expectedDataSetValue, VersionBData.PropertyValue newDataSetValue)
    {
        Assert.AreEqual(expectedDataSetValue.DataType, newDataSetValue.DataType);
        Assert.AreEqual(expectedDataSetValue.IsNull, newDataSetValue.IsNull);
        Assert.AreEqual(expectedDataSetValue.Value, newDataSetValue.Value);
    }

    /// <summary>
    /// Tests the two given metrics for equality.
    /// </summary>
    /// <param name="expectedMetric">The expected metric.</param>
    /// <param name="newMetric">The new metric.</param>
    private static void MetricEquals(VersionBProtoBufPayload.Metric expectedMetric, VersionBProtoBufPayload.Metric newMetric)
    {
        Assert.AreEqual(expectedMetric.Alias, newMetric.Alias);
        Assert.AreEqual(expectedMetric.BooleanValue, newMetric.BooleanValue);
        CollectionAssert.AreEqual(expectedMetric.BytesValue, newMetric.BytesValue);
        DataSetEquals(expectedMetric.DataSetValue, newMetric.DataSetValue);
        Assert.AreEqual(expectedMetric.DataType, newMetric.DataType);
        Assert.AreEqual(expectedMetric.DoubleValue, newMetric.DoubleValue);
        // Todo: How to handle extension value?
        //Assert.AreEqual(expectedMetric.ExtensionValue, newMetric.ExtensionValue);
        Assert.AreEqual(expectedMetric.FloatValue, newMetric.FloatValue);
        Assert.AreEqual(expectedMetric.IntValue, newMetric.IntValue);
        Assert.AreEqual(expectedMetric.IsHistorical, newMetric.IsHistorical);
        Assert.AreEqual(expectedMetric.IsNull, newMetric.IsNull);
        Assert.AreEqual(expectedMetric.IsTransient, newMetric.IsTransient);
        Assert.AreEqual(expectedMetric.LongValue, newMetric.LongValue);
        MetaDataEquals(expectedMetric.MetaData, newMetric.MetaData);
        Assert.AreEqual(expectedMetric.Name, newMetric.Name);
        PropertySetValueEquals(expectedMetric.PropertySetValue, newMetric.PropertySetValue);
        Assert.AreEqual(expectedMetric.StringValue, newMetric.StringValue);
        Assert.AreEqual(expectedMetric.TemplateValue, newMetric.TemplateValue);
        Assert.AreEqual(expectedMetric.Timestamp, newMetric.Timestamp);
    }

    /// <summary>
    /// Tests the two given data sets for equality.
    /// </summary>
    /// <param name="expectedDataSet">The expected data set.</param>
    /// <param name="newDataSet">The new data set.</param>
    private static void DataSetEquals(VersionBProtoBufPayload.DataSet? expectedDataSet, VersionBProtoBufPayload.DataSet? newDataSet)
    {
        if (expectedDataSet is not null && newDataSet is not null)
        {
            CollectionAssert.AreEqual(expectedDataSet.Columns, newDataSet.Columns);
            Assert.AreEqual(expectedDataSet.NumberOfColumns, newDataSet.NumberOfColumns);

            // Check the rows.
            var rowIndex = 0;

            foreach (var row in newDataSet.Rows)
            {
                var expectedRow = expectedDataSet.Rows[rowIndex];
                var elementIndex = 0;

                // Check the elements in the row.
                foreach (var element in row.Elements)
                {
                    var expectedElement = expectedRow.Elements[elementIndex];
                    DataSetValueEquals(expectedElement, element);
                    elementIndex++;
                }

                rowIndex++;
            }

            CollectionAssert.AreEqual(expectedDataSet.Types, newDataSet.Types);
        }
        else if (expectedDataSet is null && newDataSet is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The data set values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given data set values for equality.
    /// </summary>
    /// <param name="expectedDataSetValue">The expected data set value.</param>
    /// <param name="newDataSetValue">The new data set value.</param>
    private static void DataSetValueEquals(VersionBProtoBufPayload.DataSet.DataSetValue expectedDataSetValue, VersionBProtoBufPayload.DataSet.DataSetValue newDataSetValue)
    {
        Assert.AreEqual(expectedDataSetValue.BooleanValue, newDataSetValue.BooleanValue);
        Assert.AreEqual(expectedDataSetValue.DoubleValue, newDataSetValue.DoubleValue);
        // Todo: How to handle extension value?
        //Assert.AreEqual(expectedDataSetValue.ExtensionValue, newDataSetValue.ExtensionValue);
        Assert.AreEqual(expectedDataSetValue.FloatValue, newDataSetValue.FloatValue);
        Assert.AreEqual(expectedDataSetValue.IntValue, newDataSetValue.IntValue);
        Assert.AreEqual(expectedDataSetValue.LongValue, newDataSetValue.LongValue);
        Assert.AreEqual(expectedDataSetValue.StringValue, newDataSetValue.StringValue);
    }

    /// <summary>
    /// Tests the two given meta data for equality.
    /// </summary>
    /// <param name="expectedMetaData">The expected meta data.</param>
    /// <param name="newMetaData">The new meta data.</param>
    private static void MetaDataEquals(VersionBProtoBufPayload.MetaData? expectedMetaData, VersionBProtoBufPayload.MetaData? newMetaData)
    {
        if (expectedMetaData is not null && newMetaData is not null)
        {
            Assert.AreEqual(expectedMetaData.IsMultiPart, newMetaData.IsMultiPart);
            Assert.AreEqual(expectedMetaData.ContentType, newMetaData.ContentType);
            Assert.AreEqual(expectedMetaData.Size, newMetaData.Size);
            Assert.AreEqual(expectedMetaData.Seq, newMetaData.Seq);
            Assert.AreEqual(expectedMetaData.FileName, newMetaData.FileName);
            Assert.AreEqual(expectedMetaData.FileType, newMetaData.FileType);
            Assert.AreEqual(expectedMetaData.Md5, newMetaData.Md5);
            Assert.AreEqual(expectedMetaData.Description, newMetaData.Description);
        }
        else if (expectedMetaData is null && newMetaData is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The meta data values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given property sets for equality.
    /// </summary>
    /// <param name="expectedPropertySetValue">The expected property set.</param>
    /// <param name="newPropertySetValue">The new property set.</param>
    private static void PropertySetValueEquals(VersionBProtoBufPayload.PropertySet? expectedPropertySetValue, VersionBProtoBufPayload.PropertySet? newPropertySetValue)
    {
        if (expectedPropertySetValue is not null && newPropertySetValue is not null)
        {
            CollectionAssert.AreEqual(expectedPropertySetValue.Keys, newPropertySetValue.Keys);

            var propertyIndex = 0;

            foreach (var propertyValue in newPropertySetValue.Values)
            {
                var expectedPropertyValue = expectedPropertySetValue.Values[propertyIndex];
                PropertyValueEquals(expectedPropertyValue, propertyValue);
                propertyIndex++;
            }
        }
        else if (expectedPropertySetValue is null && newPropertySetValue is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The property set values are not equal.");
        }
    }

    /// <summary>
    /// Tests the two given property values for equality.
    /// </summary>
    /// <param name="expectedDataSetValue">The expected property value.</param>
    /// <param name="newDataSetValue">The new property value.</param>
    private static void PropertyValueEquals(VersionBProtoBufPayload.PropertyValue expectedDataSetValue, VersionBProtoBufPayload.PropertyValue newDataSetValue)
    {
        Assert.AreEqual(expectedDataSetValue.BooleanValue, newDataSetValue.BooleanValue);
        Assert.AreEqual(expectedDataSetValue.DataType, newDataSetValue.DataType);
        Assert.AreEqual(expectedDataSetValue.DoubleValue, newDataSetValue.DoubleValue);
        // Todo: How to handle extension value?
        //Assert.AreEqual(expectedDataSetValue.ExtensionValue, newDataSetValue.ExtensionValue);
        Assert.AreEqual(expectedDataSetValue.FloatValue, newDataSetValue.FloatValue);
        Assert.AreEqual(expectedDataSetValue.IntValue, newDataSetValue.IntValue);
        Assert.AreEqual(expectedDataSetValue.IsNull, newDataSetValue.IsNull);
        Assert.AreEqual(expectedDataSetValue.LongValue, newDataSetValue.LongValue);

        if (expectedDataSetValue.PropertySetListValue is not null && newDataSetValue.PropertySetListValue is not null)
        {
            var propertyIndex = 0;

            foreach (var propertySetValue in newDataSetValue.PropertySetListValue.PropertySets)
            {
                var expectedPropertySetValue = expectedDataSetValue.PropertySetListValue.PropertySets[propertyIndex];
                PropertySetValueEquals(expectedPropertySetValue, propertySetValue);
                propertyIndex++;
            }
        }
        else if (expectedDataSetValue.PropertySetListValue is null && newDataSetValue.PropertySetListValue is null)
        {
            // Do nothing here.
        }
        else
        {
            Assert.Fail("The property set list values are not equal.");
        }

        PropertySetValueEquals(expectedDataSetValue.PropertySetValue, newDataSetValue.PropertySetValue);
        Assert.AreEqual(expectedDataSetValue.StringValue, newDataSetValue.StringValue);
    }
}
