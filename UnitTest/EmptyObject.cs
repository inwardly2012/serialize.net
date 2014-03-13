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
using System.Diagnostics;

namespace HotChai.Serialization.UnitTest
{
    public sealed class EmptyObject
    {
        private EmptyObject()
        {
        }

        public static EmptyObject Create()
        {
            return new EmptyObject();
        }

        public static void WriteTo(
            IObjectWriter writer,
            EmptyObject emptyObject)
        {
            if (null == emptyObject)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            writer.WriteEndObject();
        }

        public static EmptyObject ReadFrom(
            IObjectReader reader)
        {
            EmptyObject emptyObject = null;

            if (reader.ReadStartObject())
            {
                emptyObject = new EmptyObject();

                int memberKey;

                while (reader.ReadNextMemberKey())
                {
                    memberKey = reader.MemberKey;

                    Debug.WriteLine("Skipping member key {0}", memberKey);
                }

                // TODO: Should ReadEndObject skip any remaining members?
                reader.ReadEndObject();
            }

            return emptyObject;
        }
    }
}
