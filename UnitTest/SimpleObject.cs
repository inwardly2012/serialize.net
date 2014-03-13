﻿#region License
// Copyright (c) 2014, David Taylor
//
// Permission to use, copy, modify, and/or distribute this software for any 
// purpose with or without fee is hereby granted, provided that the above 
// copyright notice and this permission notice appear in all copies, unless 
// such copies are solely in the form of machine-executable object code 
// generated by a source language processor.
//
// THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES 
// WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF 
// MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR 
// ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES 
// WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN 
// ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF 
// OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
#endregion License
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HotChai.Serialization.UnitTest
{
    public sealed class SimpleObject
    {
        private const int StringQuotaInBytes = 1024;

        private static class MemberKey
        {
            public const int StringValue = 1;
            public const int WriteOnlyStringValue = 2;

            public const int StringEmptyValue = 3;
            public const int WriteOnlyStringEmptyValue = 4;

            public const int StringNullValue = 5;
            public const int WriteOnlyStringNullValue = 6;

            public const int ByteArrayValue = 7;
            public const int WriteOnlyByteArrayValue = 8;

            public const int ByteArrayEmptyValue = 9;
            public const int WriteOnlyByteArrayEmptyValue = 10;

            public const int ByteArrayNullValue = 11;
            public const int WriteOnlyByteArrayNullValue = 12;

            public const int Int32ZeroValue = 13;
            public const int WriteOnlyInt32ZeroValue = 14;

            public const int Int32MinValue = 15;
            public const int WriteOnlyInt32MinValue = 16;

            public const int Int32MaxValue = 17;
            public const int WriteOnlyInt32MaxValue = 18;

            public const int UInt32MinValue = 19;
            public const int WriteOnlyUInt32MinValue = 20;

            public const int UInt32MaxValue = 21;
            public const int WriteOnlyUInt32MaxValue = 22;

            public const int SingleValue = 23;
            public const int WriteOnlySingleValue = 24;

            public const int SingleMinValue = 25;
            public const int WriteOnlySingleMinValue = 26;

            public const int SingleMaxValue = 27;
            public const int WriteOnlySingleMaxValue = 28;

            public const int Int32ArrayValue = 29;
            public const int WriteOnlyInt32ArrayValue = 30;

            public const int Int32ArrayEmptyValue = 31;
            public const int WriteOnlyInt32ArrayEmptyValue = 32;

            public const int Int32ArrayNullValue = 33;
            public const int WriteOnlyInt32ArrayNullValue = 34;

            public const int StringArrayValue = 35;
            public const int WriteOnlyStringArrayValue = 36;

            public const int StringArrayEmptyValue = 37;
            public const int WriteOnlyStringArrayEmptyValue = 38;

            public const int StringArrayNullValue = 39;
            public const int WriteOnlyStringArrayNullValue = 40;

            public const int StringWithEscapesValue = 41;
            public const int WriteOnlyStringWithEscapesValue = 42;

            public const int StringWithSurrogatePairsValue = 43;
            public const int WriteOnlyStringWithSurrogatePairsValue = 44;

            public const int DoubleValue = 45;
            public const int WriteOnlyDoubleValue = 46;

            public const int DoubleMinValue = 47;
            public const int WriteOnlyDoubleMinValue = 48;

            public const int DoubleMaxValue = 49;
            public const int WriteOnlyDoubleMaxValue = 50;

            public const int Int64ZeroValue = 51;
            public const int WriteOnlyInt64ZeroValue = 52;

            public const int Int64MinValue = 53;
            public const int WriteOnlyInt64MinValue = 54;

            public const int Int64MaxValue = 55;
            public const int WriteOnlyInt64MaxValue = 56;

            public const int UInt64ZeroValue = 57;
            public const int WriteOnlyUInt64ZeroValue = 58;

            public const int UInt64MinValue = 59;
            public const int WriteOnlyUInt64MinValue = 60;

            public const int UInt64MaxValue = 61;
            public const int WriteOnlyUInt64MaxValue = 62;

            public const int BooleanTrueValue = 63;
            public const int WriteOnlyBooleanTrueValue = 64;

            public const int BooleanFalseValue = 65;
            public const int WriteOnlyBooleanFalseValue = 66;

            public const int BooleanArrayValue = 67;
            public const int WriteOnlyBooleanArrayValue = 68;
        }

        private SimpleObject()
        {
        }

        public static readonly SimpleObject Invalid = new SimpleObject() { StringValue = "Invalid" };

        public static SimpleObject Create()
        {
            SimpleObject simpleObject = new SimpleObject()
            {
                StringValue = "String",
                StringEmptyValue = String.Empty,
                StringNullValue = null,
                ByteArrayValue = new byte[] { 1, 2, 3 },
                ByteArrayEmptyValue = new byte[] { },
                ByteArrayNullValue = null,
                Int32ZeroValue = 0,
                Int32MinValue = Int32.MinValue,
                Int32MaxValue = Int32.MaxValue,
                UInt32MinValue = UInt32.MinValue,
                UInt32MaxValue = UInt32.MaxValue,
                SingleValue = 3.14159265359f,
                SingleMinValue = Single.MinValue,
                SingleMaxValue = Single.MaxValue,
                Int32ArrayValue = new int[] { 1, 2, 3 },
                Int32ArrayEmptyValue = new int[] { },
                Int32ArrayNullValue = null,
                StringArrayValue = new string[] { "One", null, String.Empty, "Four" },
                StringArrayEmptyValue = new string[] { },
                StringArrayNullValue = null,
                StringWithEscapesValue = "\"\\\b\f\n\r\t\u0000\u0001><][}{",
                StringWithSurrogatePairsValue = "\U0001f680\U0001f60a",
                DoubleValue = 3.14159265359,
                DoubleMinValue = Double.MinValue,
                DoubleMaxValue = Double.MaxValue,
                Int64ZeroValue = 0,
                Int64MinValue = Int64.MinValue,
                Int64MaxValue = Int64.MaxValue,
                UInt64ZeroValue = 0,
                UInt64MinValue = UInt64.MinValue,
                UInt64MaxValue = UInt64.MaxValue,
                BooleanTrueValue = true,
                BooleanFalseValue = false,
                BooleanArrayValue = new bool[] { true, false, true },
            };

            return simpleObject;
        }

        private string StringValue { get; set; }
        private string StringEmptyValue { get; set; }
        private string StringNullValue { get; set; }
        private byte[] ByteArrayValue { get; set; }
        private byte[] ByteArrayEmptyValue { get; set; }
        private byte[] ByteArrayNullValue { get; set; }
        private int Int32ZeroValue { get; set; }
        private int Int32MinValue { get; set; }
        private int Int32MaxValue { get; set; }
        private uint UInt32MinValue { get; set; }
        private uint UInt32MaxValue { get; set; }
        private float SingleValue { get; set; }
        private float SingleMinValue { get; set; }
        private float SingleMaxValue { get; set; }
        private int[] Int32ArrayValue { get; set; }
        private int[] Int32ArrayEmptyValue { get; set; }
        private int[] Int32ArrayNullValue { get; set; }
        private string[] StringArrayValue { get; set; }
        private string[] StringArrayEmptyValue { get; set; }
        private string[] StringArrayNullValue { get; set; }
        private string StringWithEscapesValue { get; set; }
        private string StringWithSurrogatePairsValue { get; set; }
        private double DoubleValue { get; set; }
        private double DoubleMinValue { get; set; }
        private double DoubleMaxValue { get; set; }
        private long Int64ZeroValue { get; set; }
        private long Int64MinValue { get; set; }
        private long Int64MaxValue { get; set; }
        private ulong UInt64ZeroValue { get; set; }
        private ulong UInt64MinValue { get; set; }
        private ulong UInt64MaxValue { get; set; }
        private bool BooleanTrueValue { get; set; }
        private bool BooleanFalseValue { get; set; }
        private bool[] BooleanArrayValue { get; set; }

        public static void WriteTo(
            IObjectWriter writer,
            SimpleObject simpleObject)
        {
            if (null == simpleObject)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            // String
            writer.WriteStartMember(MemberKey.StringValue);
            writer.WriteValue(simpleObject.StringValue);
            writer.WriteEndMember();

            // String (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyStringValue);
            writer.WriteValue(simpleObject.StringValue);
            writer.WriteEndMember();

            // Empty String
            writer.WriteStartMember(MemberKey.StringEmptyValue);
            writer.WriteValue(simpleObject.StringEmptyValue);
            writer.WriteEndMember();

            // Empty String (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyStringEmptyValue);
            writer.WriteValue(simpleObject.StringEmptyValue);
            writer.WriteEndMember();

            // Null String
            writer.WriteStartMember(MemberKey.StringNullValue);
            writer.WriteValue(simpleObject.StringNullValue);
            writer.WriteEndMember();

            // Null String (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyStringNullValue);
            writer.WriteValue(simpleObject.StringNullValue);
            writer.WriteEndMember();

            // Byte[]
            writer.WriteStartMember(MemberKey.ByteArrayValue);
            writer.WriteValue(simpleObject.ByteArrayValue);
            writer.WriteEndMember();

            // Byte[] (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyByteArrayValue);
            writer.WriteValue(simpleObject.ByteArrayValue);
            writer.WriteEndMember();

            // Empty Byte[]
            writer.WriteStartMember(MemberKey.ByteArrayEmptyValue);
            writer.WriteValue(simpleObject.ByteArrayEmptyValue);
            writer.WriteEndMember();

            // Empty Byte[] (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyByteArrayEmptyValue);
            writer.WriteValue(simpleObject.ByteArrayEmptyValue);
            writer.WriteEndMember();

            // Null Byte[]
            writer.WriteStartMember(MemberKey.ByteArrayNullValue);
            writer.WriteValue(simpleObject.ByteArrayNullValue);
            writer.WriteEndMember();

            // Null Byte[] (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyByteArrayNullValue);
            writer.WriteValue(simpleObject.ByteArrayNullValue);
            writer.WriteEndMember();

            // 0 Int
            writer.WriteStartMember(MemberKey.Int32ZeroValue);
            writer.WriteValue(simpleObject.Int32ZeroValue);
            writer.WriteEndMember();

            // 0 Int (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyInt32ZeroValue);
            writer.WriteValue(simpleObject.Int32ZeroValue);
            writer.WriteEndMember();

            // Min Int
            writer.WriteStartMember(MemberKey.Int32MinValue);
            writer.WriteValue(simpleObject.Int32MinValue);
            writer.WriteEndMember();

            // Min Int (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyInt32MinValue);
            writer.WriteValue(simpleObject.Int32MinValue);
            writer.WriteEndMember();

            // Max Int
            writer.WriteStartMember(MemberKey.Int32MaxValue);
            writer.WriteValue(simpleObject.Int32MaxValue);
            writer.WriteEndMember();

            // Max Int (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyInt32MaxValue);
            writer.WriteValue(simpleObject.Int32MaxValue);
            writer.WriteEndMember();

            // Min UInt32
            writer.WriteStartMember(MemberKey.UInt32MinValue);
            writer.WriteValue(simpleObject.UInt32MinValue);
            writer.WriteEndMember();

            // Min UInt32 (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyUInt32MinValue);
            writer.WriteValue(simpleObject.UInt32MinValue);
            writer.WriteEndMember();

            // Max UInt32
            writer.WriteStartMember(MemberKey.UInt32MaxValue);
            writer.WriteValue(simpleObject.UInt32MaxValue);
            writer.WriteEndMember();

            // Max UInt32 (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlyUInt32MaxValue);
            writer.WriteValue(simpleObject.UInt32MaxValue);
            writer.WriteEndMember();

            // Single
            writer.WriteStartMember(MemberKey.SingleValue);
            writer.WriteValue(simpleObject.SingleValue);
            writer.WriteEndMember();

            // Single (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlySingleValue);
            writer.WriteValue(simpleObject.SingleValue);
            writer.WriteEndMember();

            // Min Single
            writer.WriteStartMember(MemberKey.SingleMinValue);
            writer.WriteValue(simpleObject.SingleMinValue);
            writer.WriteEndMember();

            // Min Single (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlySingleMinValue);
            writer.WriteValue(simpleObject.SingleMinValue);
            writer.WriteEndMember();

            // Max Single
            writer.WriteStartMember(MemberKey.SingleMaxValue);
            writer.WriteValue(simpleObject.SingleMaxValue);
            writer.WriteEndMember();

            // Max Single (write-only)
            writer.WriteStartMember(MemberKey.WriteOnlySingleMaxValue);
            writer.WriteValue(simpleObject.SingleMaxValue);
            writer.WriteEndMember();

            // Int32 Array
            writer.WriteMember(MemberKey.Int32ArrayValue, simpleObject.Int32ArrayValue);

            // Int32 Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyInt32ArrayValue, simpleObject.Int32ArrayValue);

            // Empty Int32 Array
            writer.WriteMember(MemberKey.Int32ArrayEmptyValue, simpleObject.Int32ArrayEmptyValue);

            // Empty Int32 Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyInt32ArrayEmptyValue, simpleObject.Int32ArrayEmptyValue);

            // Null Int32 Array
            writer.WriteMember(MemberKey.Int32ArrayNullValue, simpleObject.Int32ArrayNullValue);

            // Null Int32 Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyInt32ArrayNullValue, simpleObject.Int32ArrayNullValue);

            // String Array
            writer.WriteMember(MemberKey.StringArrayValue, simpleObject.StringArrayValue);

            // String Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyStringArrayValue, simpleObject.StringArrayValue);

            // Empty String Array
            writer.WriteMember(MemberKey.StringArrayEmptyValue, simpleObject.StringArrayEmptyValue);

            // Empty String Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyStringArrayEmptyValue, simpleObject.StringArrayEmptyValue);

            // Null String Array
            writer.WriteMember(MemberKey.StringArrayNullValue, simpleObject.StringArrayNullValue);

            // Null String Array (write-only)
            writer.WriteMember(MemberKey.WriteOnlyStringArrayNullValue, simpleObject.StringArrayNullValue);

            // String with escapes
            writer.WriteMember(MemberKey.StringWithEscapesValue, simpleObject.StringWithEscapesValue);

            // Write-only string with escapes
            writer.WriteMember(MemberKey.WriteOnlyStringWithEscapesValue, simpleObject.StringWithEscapesValue);

            // String with surrogate pairs
            writer.WriteMember(MemberKey.StringWithSurrogatePairsValue, simpleObject.StringWithSurrogatePairsValue);

            // Write-only string with surrogate pairs
            writer.WriteMember(MemberKey.WriteOnlyStringWithSurrogatePairsValue, simpleObject.StringWithSurrogatePairsValue);

            // Double
            writer.WriteMember(MemberKey.DoubleValue, simpleObject.DoubleValue);
            writer.WriteMember(MemberKey.WriteOnlyDoubleValue, simpleObject.DoubleValue);

            // Min double
            writer.WriteMember(MemberKey.DoubleMinValue, simpleObject.DoubleMinValue);
            writer.WriteMember(MemberKey.WriteOnlyDoubleMinValue, simpleObject.DoubleMinValue);

            // Max double
            writer.WriteMember(MemberKey.DoubleMaxValue, simpleObject.DoubleMaxValue);
            writer.WriteMember(MemberKey.WriteOnlyDoubleMaxValue, simpleObject.DoubleMaxValue);

            // Int64
            writer.WriteMember(MemberKey.Int64ZeroValue, simpleObject.Int64ZeroValue);
            writer.WriteMember(MemberKey.WriteOnlyInt64ZeroValue, simpleObject.Int64ZeroValue);

            // Min Int64
            writer.WriteMember(MemberKey.Int64MinValue, simpleObject.Int64MinValue);
            writer.WriteMember(MemberKey.WriteOnlyInt64MinValue, simpleObject.Int64MinValue);

            // Max Int64
            writer.WriteMember(MemberKey.Int64MaxValue, simpleObject.Int64MaxValue);
            writer.WriteMember(MemberKey.WriteOnlyInt64MaxValue, simpleObject.Int64MaxValue);

            // UInt64
            writer.WriteMember(MemberKey.UInt64ZeroValue, simpleObject.UInt64ZeroValue);
            writer.WriteMember(MemberKey.WriteOnlyUInt64ZeroValue, simpleObject.UInt64ZeroValue);

            // Min UInt64
            writer.WriteMember(MemberKey.UInt64MinValue, simpleObject.UInt64MinValue);
            writer.WriteMember(MemberKey.WriteOnlyUInt64MinValue, simpleObject.UInt64MinValue);

            // Max UInt64
            writer.WriteMember(MemberKey.UInt64MaxValue, simpleObject.UInt64MaxValue);
            writer.WriteMember(MemberKey.WriteOnlyUInt64MaxValue, simpleObject.UInt64MaxValue);

            // Boolean true
            writer.WriteMember(MemberKey.BooleanTrueValue, simpleObject.BooleanTrueValue);
            writer.WriteMember(MemberKey.WriteOnlyBooleanTrueValue, simpleObject.BooleanTrueValue);

            // Boolean false
            writer.WriteMember(MemberKey.BooleanFalseValue, simpleObject.BooleanFalseValue);
            writer.WriteMember(MemberKey.WriteOnlyBooleanFalseValue, simpleObject.BooleanFalseValue);

            // Boolean array
            writer.WriteMember(MemberKey.BooleanArrayValue, simpleObject.BooleanArrayValue);
            writer.WriteMember(MemberKey.WriteOnlyBooleanArrayValue, simpleObject.BooleanArrayValue);

            writer.WriteEndObject();
        }

        public static SimpleObject ReadFrom(
            IObjectReader reader)
        {
            SimpleObject simpleObject = null;

            if (reader.ReadStartObject())
            {
                simpleObject = new SimpleObject();

                int memberKey;

                while (reader.ReadNextMemberKey())
                {
                    memberKey = reader.MemberKey;

                    if (memberKey == MemberKey.StringValue)
                    {
                        simpleObject.StringValue = reader.ReadValueAsString(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.StringEmptyValue)
                    {
                        simpleObject.StringEmptyValue = reader.ReadValueAsString(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.StringNullValue)
                    {
                        simpleObject.StringNullValue = reader.ReadValueAsString(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.ByteArrayValue)
                    {
                        simpleObject.ByteArrayValue = reader.ReadValueAsBytes(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.ByteArrayEmptyValue)
                    {
                        simpleObject.ByteArrayEmptyValue = reader.ReadValueAsBytes(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.ByteArrayNullValue)
                    {
                        simpleObject.ByteArrayNullValue = reader.ReadValueAsBytes(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.Int32ZeroValue)
                    {
                        simpleObject.Int32ZeroValue = reader.ReadValueAsInt32();
                    }
                    else if (memberKey == MemberKey.Int32MinValue)
                    {
                        simpleObject.Int32MinValue = reader.ReadValueAsInt32();
                    }
                    else if (memberKey == MemberKey.Int32MaxValue)
                    {
                        simpleObject.Int32MaxValue = reader.ReadValueAsInt32();
                    }
                    else if (memberKey == MemberKey.UInt32MinValue)
                    {
                        simpleObject.UInt32MinValue = reader.ReadValueAsUInt32();
                    }
                    else if (memberKey == MemberKey.UInt32MaxValue)
                    {
                        simpleObject.UInt32MaxValue = reader.ReadValueAsUInt32();
                    }
                    else if (memberKey == MemberKey.SingleValue)
                    {
                        simpleObject.SingleValue = reader.ReadValueAsSingle();
                    }
                    else if (memberKey == MemberKey.SingleMinValue)
                    {
                        simpleObject.SingleMinValue = reader.ReadValueAsSingle();
                    }
                    else if (memberKey == MemberKey.SingleMaxValue)
                    {
                        simpleObject.SingleMaxValue = reader.ReadValueAsSingle();
                    }
                    else if (memberKey == MemberKey.Int32ArrayValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<int> list = new List<int>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsInt32());
                            }

                            reader.ReadEndArray();

                            simpleObject.Int32ArrayValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.Int32ArrayEmptyValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<int> list = new List<int>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsInt32());
                            }

                            reader.ReadEndArray();

                            simpleObject.Int32ArrayEmptyValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.Int32ArrayNullValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<int> list = new List<int>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsInt32());
                            }

                            reader.ReadEndArray();

                            simpleObject.Int32ArrayNullValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.StringArrayValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<string> list = new List<string>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsString(StringQuotaInBytes));
                            }

                            reader.ReadEndArray();

                            simpleObject.StringArrayValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.StringArrayEmptyValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<string> list = new List<string>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsString(StringQuotaInBytes));
                            }

                            reader.ReadEndArray();

                            simpleObject.StringArrayEmptyValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.StringArrayNullValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<string> list = new List<string>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsString(StringQuotaInBytes));
                            }

                            reader.ReadEndArray();

                            simpleObject.StringArrayNullValue = list.ToArray();
                        }
                    }
                    else if (memberKey == MemberKey.StringWithEscapesValue)
                    {
                        simpleObject.StringWithEscapesValue = reader.ReadValueAsString(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.StringWithSurrogatePairsValue)
                    {
                        simpleObject.StringWithSurrogatePairsValue = reader.ReadValueAsString(StringQuotaInBytes);
                    }
                    else if (memberKey == MemberKey.DoubleValue)
                    {
                        simpleObject.DoubleValue = reader.ReadValueAsDouble();
                    }
                    else if (memberKey == MemberKey.DoubleMinValue)
                    {
                        simpleObject.DoubleMinValue = reader.ReadValueAsDouble();
                    }
                    else if (memberKey == MemberKey.DoubleMaxValue)
                    {
                        simpleObject.DoubleMaxValue = reader.ReadValueAsDouble();
                    }
                    else if (memberKey == MemberKey.Int64ZeroValue)
                    {
                        simpleObject.Int64ZeroValue = reader.ReadValueAsInt64();
                    }
                    else if (memberKey == MemberKey.Int64MinValue)
                    {
                        simpleObject.Int64MinValue = reader.ReadValueAsInt64();
                    }
                    else if (memberKey == MemberKey.Int64MaxValue)
                    {
                        simpleObject.Int64MaxValue = reader.ReadValueAsInt64();
                    }
                    else if (memberKey == MemberKey.UInt64ZeroValue)
                    {
                        simpleObject.UInt64ZeroValue = reader.ReadValueAsUInt64();
                    }
                    else if (memberKey == MemberKey.UInt64MinValue)
                    {
                        simpleObject.UInt64MinValue = reader.ReadValueAsUInt64();
                    }
                    else if (memberKey == MemberKey.UInt64MaxValue)
                    {
                        simpleObject.UInt64MaxValue = reader.ReadValueAsUInt64();
                    }
                    else if (memberKey == MemberKey.BooleanTrueValue)
                    {
                        simpleObject.BooleanTrueValue = reader.ReadValueAsBoolean();
                    }
                    else if (memberKey == MemberKey.BooleanFalseValue)
                    {
                        simpleObject.BooleanFalseValue = reader.ReadValueAsBoolean();
                    }
                    else if (memberKey == MemberKey.BooleanArrayValue)
                    {
                        if (reader.ReadStartArray())
                        {
                            List<bool> list = new List<bool>();

                            while (reader.MoveToNextArrayValue())
                            {
                                list.Add(reader.ReadValueAsBoolean());
                            }

                            reader.ReadEndArray();

                            simpleObject.BooleanArrayValue = list.ToArray();
                        }
                    }
                    //else
                    //{
                    //    Debug.WriteLine("Skipping member key {0}", memberKey);
                    //}
                }

                reader.ReadEndObject();
            }

            return simpleObject;
        }

        public void VerifyIsEqual(
            SimpleObject other)
        {
            if (this.StringValue != other.StringValue)
            {
                throw new Exception("StringValue does not match.");
            }

            if (this.StringEmptyValue != other.StringEmptyValue)
            {
                throw new Exception("StringEmptyValue does not match.");
            }

            if (this.StringNullValue != other.StringNullValue)
            {
                throw new Exception("StringNullValue does not match.");
            }

            if (!ArrayComparer<byte>.Equals(this.ByteArrayValue, other.ByteArrayValue))
            {
                throw new Exception("ByteArrayValue does not match.");
            }

            if (!ArrayComparer<byte>.Equals(this.ByteArrayEmptyValue, other.ByteArrayEmptyValue))
            {
                throw new Exception("ByteArrayEmptyValue does not match.");
            }

            if (!ArrayComparer<byte>.Equals(this.ByteArrayNullValue, other.ByteArrayNullValue))
            {
                throw new Exception("ByteArrayNullValue does not match.");
            }

            if (this.Int32ZeroValue != other.Int32ZeroValue)
            {
                throw new Exception("Int32ZeroValue does not match.");
            }

            if (this.Int32MinValue != other.Int32MinValue)
            {
                throw new Exception("Int32MinValue does not match.");
            }

            if (this.Int32MaxValue != other.Int32MaxValue)
            {
                throw new Exception("Int32MaxValue does not match.");
            }

            if (this.UInt32MinValue != other.UInt32MinValue)
            {
                throw new Exception("UInt32MinValue does not match.");
            }

            if (this.UInt32MaxValue != other.UInt32MaxValue)
            {
                throw new Exception("UInt32MaxValue does not match.");
            }

            if (this.SingleValue != other.SingleValue)
            {
                throw new Exception("SingleValue does not match.");
            }

            if (this.SingleMinValue != other.SingleMinValue)
            {
                throw new Exception("SingleMinValue does not match.");
            }

            if (this.SingleMaxValue != other.SingleMaxValue)
            {
                throw new Exception("SingleMaxValue does not match.");
            }

            if (!ArrayComparer<int>.Equals(this.Int32ArrayValue, other.Int32ArrayValue))
            {
                throw new Exception("Int32ArrayValue does not match.");
            }

            if (!ArrayComparer<int>.Equals(this.Int32ArrayEmptyValue, other.Int32ArrayEmptyValue))
            {
                throw new Exception("Int32ArrayEmptyValue does not match.");
            }

            if (!ArrayComparer<int>.Equals(this.Int32ArrayNullValue, other.Int32ArrayNullValue))
            {
                throw new Exception("Int32ArrayNullValue does not match.");
            }

            if (!ArrayComparer<string>.Equals(this.StringArrayValue, other.StringArrayValue))
            {
                throw new Exception("StringArrayValue does not match.");
            }

            if (!ArrayComparer<string>.Equals(this.StringArrayEmptyValue, other.StringArrayEmptyValue))
            {
                throw new Exception("StringArrayEmptyValue does not match.");
            }

            if (!ArrayComparer<string>.Equals(this.StringArrayNullValue, other.StringArrayNullValue))
            {
                throw new Exception("StringArrayNullValue does not match.");
            }

            if (this.StringWithEscapesValue != other.StringWithEscapesValue)
            {
                throw new Exception("StringWithEscapesValue does not match.");
            }

            if (this.StringWithSurrogatePairsValue != other.StringWithSurrogatePairsValue)
            {
                throw new Exception("StringWithSurrogatePairsValue does not match.");
            }

            if (this.DoubleValue != other.DoubleValue)
            {
                throw new Exception("DoubleValue does not match.");
            }

            if (this.DoubleMinValue != other.DoubleMinValue)
            {
                throw new Exception("DoubleMinValue does not match.");
            }

            if (this.DoubleMaxValue != other.DoubleMaxValue)
            {
                throw new Exception("DoubleMaxValue does not match.");
            }

            if (this.Int64ZeroValue != other.Int64ZeroValue)
            {
                throw new Exception("Int64ZeroValue does not match.");
            }

            if (this.Int64MinValue != other.Int64MinValue)
            {
                throw new Exception("Int64MinValue does not match.");
            }

            if (this.Int64MaxValue != other.Int64MaxValue)
            {
                throw new Exception("Int64MaxValue does not match.");
            }

            if (this.UInt64ZeroValue != other.UInt64ZeroValue)
            {
                throw new Exception("UInt64ZeroValue does not match.");
            }

            if (this.UInt64MinValue != other.UInt64MinValue)
            {
                throw new Exception("UInt64MinValue does not match.");
            }

            if (this.UInt64MaxValue != other.UInt64MaxValue)
            {
                throw new Exception("UInt64MaxValue does not match.");
            }

            if (this.BooleanTrueValue != other.BooleanTrueValue)
            {
                throw new Exception("BooleanTrueValue does not match.");
            }

            if (this.BooleanFalseValue != other.BooleanFalseValue)
            {
                throw new Exception("BooleanFalseValue does not match.");
            }

            if (!ArrayComparer<bool>.Equals(this.BooleanArrayValue, other.BooleanArrayValue))
            {
                throw new Exception("BooleanArrayValue does not match.");
            }
        }
    }
}
