﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SparkplugNet.Payloads.VersionA
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Payload : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"timestamp")]
        public long Timestamp
        {
            get => __pbn__Timestamp.GetValueOrDefault();
            set => __pbn__Timestamp = value;
        }
        public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
        public void ResetTimestamp() => __pbn__Timestamp = null;
        private long? __pbn__Timestamp;

        [global::ProtoBuf.ProtoMember(2, Name = @"position")]
        public KuraPosition Position { get; set; }

        [global::ProtoBuf.ProtoMember(5000, Name = @"metric")]
        public global::System.Collections.Generic.List<KuraMetric> Metrics { get; set; } = new global::System.Collections.Generic.List<KuraMetric>();

        [global::ProtoBuf.ProtoMember(5001, Name = @"body")]
        public byte[] Body
        {
            get => __pbn__Body;
            set => __pbn__Body = value;
        }
        public bool ShouldSerializeBody() => __pbn__Body != null;
        public void ResetBody() => __pbn__Body = null;
        private byte[] __pbn__Body;

        [global::ProtoBuf.ProtoContract()]
        public partial class KuraMetric : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"name", IsRequired = true)]
            public string Name { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"type", IsRequired = true)]
            public ValueType Type { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"double_value")]
            public double DoubleValue
            {
                get => __pbn__DoubleValue.GetValueOrDefault();
                set => __pbn__DoubleValue = value;
            }
            public bool ShouldSerializeDoubleValue() => __pbn__DoubleValue != null;
            public void ResetDoubleValue() => __pbn__DoubleValue = null;
            private double? __pbn__DoubleValue;

            [global::ProtoBuf.ProtoMember(4, Name = @"float_value")]
            public float FloatValue
            {
                get => __pbn__FloatValue.GetValueOrDefault();
                set => __pbn__FloatValue = value;
            }
            public bool ShouldSerializeFloatValue() => __pbn__FloatValue != null;
            public void ResetFloatValue() => __pbn__FloatValue = null;
            private float? __pbn__FloatValue;

            [global::ProtoBuf.ProtoMember(5, Name = @"long_value")]
            public long LongValue
            {
                get => __pbn__LongValue.GetValueOrDefault();
                set => __pbn__LongValue = value;
            }
            public bool ShouldSerializeLongValue() => __pbn__LongValue != null;
            public void ResetLongValue() => __pbn__LongValue = null;
            private long? __pbn__LongValue;

            [global::ProtoBuf.ProtoMember(6, Name = @"int_value")]
            public int IntValue
            {
                get => __pbn__IntValue.GetValueOrDefault();
                set => __pbn__IntValue = value;
            }
            public bool ShouldSerializeIntValue() => __pbn__IntValue != null;
            public void ResetIntValue() => __pbn__IntValue = null;
            private int? __pbn__IntValue;

            [global::ProtoBuf.ProtoMember(7, Name = @"bool_value")]
            public bool BoolValue
            {
                get => __pbn__BoolValue.GetValueOrDefault();
                set => __pbn__BoolValue = value;
            }
            public bool ShouldSerializeBoolValue() => __pbn__BoolValue != null;
            public void ResetBoolValue() => __pbn__BoolValue = null;
            private bool? __pbn__BoolValue;

            [global::ProtoBuf.ProtoMember(8, Name = @"string_value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get => __pbn__StringValue ?? "";
                set => __pbn__StringValue = value;
            }
            public bool ShouldSerializeStringValue() => __pbn__StringValue != null;
            public void ResetStringValue() => __pbn__StringValue = null;
            private string __pbn__StringValue;

            [global::ProtoBuf.ProtoMember(9, Name = @"bytes_value")]
            public byte[] BytesValue
            {
                get => __pbn__BytesValue;
                set => __pbn__BytesValue = value;
            }
            public bool ShouldSerializeBytesValue() => __pbn__BytesValue != null;
            public void ResetBytesValue() => __pbn__BytesValue = null;
            private byte[] __pbn__BytesValue;

            [global::ProtoBuf.ProtoContract()]
            public enum ValueType
            {
                [global::ProtoBuf.ProtoEnum(Name = @"DOUBLE")]
                Double = 0,
                [global::ProtoBuf.ProtoEnum(Name = @"FLOAT")]
                Float = 1,
                [global::ProtoBuf.ProtoEnum(Name = @"INT64")]
                Int64 = 2,
                [global::ProtoBuf.ProtoEnum(Name = @"INT32")]
                Int32 = 3,
                [global::ProtoBuf.ProtoEnum(Name = @"BOOL")]
                Bool = 4,
                [global::ProtoBuf.ProtoEnum(Name = @"STRING")]
                String = 5,
                [global::ProtoBuf.ProtoEnum(Name = @"BYTES")]
                Bytes = 6,
            }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class KuraPosition : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"latitude", IsRequired = true)]
            public double Latitude { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"longitude", IsRequired = true)]
            public double Longitude { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"altitude")]
            public double Altitude
            {
                get => __pbn__Altitude.GetValueOrDefault();
                set => __pbn__Altitude = value;
            }
            public bool ShouldSerializeAltitude() => __pbn__Altitude != null;
            public void ResetAltitude() => __pbn__Altitude = null;
            private double? __pbn__Altitude;

            [global::ProtoBuf.ProtoMember(4, Name = @"precision")]
            public double Precision
            {
                get => __pbn__Precision.GetValueOrDefault();
                set => __pbn__Precision = value;
            }
            public bool ShouldSerializePrecision() => __pbn__Precision != null;
            public void ResetPrecision() => __pbn__Precision = null;
            private double? __pbn__Precision;

            [global::ProtoBuf.ProtoMember(5, Name = @"heading")]
            public double Heading
            {
                get => __pbn__Heading.GetValueOrDefault();
                set => __pbn__Heading = value;
            }
            public bool ShouldSerializeHeading() => __pbn__Heading != null;
            public void ResetHeading() => __pbn__Heading = null;
            private double? __pbn__Heading;

            [global::ProtoBuf.ProtoMember(6, Name = @"speed")]
            public double Speed
            {
                get => __pbn__Speed.GetValueOrDefault();
                set => __pbn__Speed = value;
            }
            public bool ShouldSerializeSpeed() => __pbn__Speed != null;
            public void ResetSpeed() => __pbn__Speed = null;
            private double? __pbn__Speed;

            [global::ProtoBuf.ProtoMember(7, Name = @"timestamp")]
            public long Timestamp
            {
                get => __pbn__Timestamp.GetValueOrDefault();
                set => __pbn__Timestamp = value;
            }
            public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
            public void ResetTimestamp() => __pbn__Timestamp = null;
            private long? __pbn__Timestamp;

            [global::ProtoBuf.ProtoMember(8, Name = @"satellites")]
            public int Satellites
            {
                get => __pbn__Satellites.GetValueOrDefault();
                set => __pbn__Satellites = value;
            }
            public bool ShouldSerializeSatellites() => __pbn__Satellites != null;
            public void ResetSatellites() => __pbn__Satellites = null;
            private int? __pbn__Satellites;

            [global::ProtoBuf.ProtoMember(9, Name = @"status")]
            public int Status
            {
                get => __pbn__Status.GetValueOrDefault();
                set => __pbn__Status = value;
            }
            public bool ShouldSerializeStatus() => __pbn__Status != null;
            public void ResetStatus() => __pbn__Status = null;
            private int? __pbn__Status;

        }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion