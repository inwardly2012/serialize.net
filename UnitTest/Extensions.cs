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
using System.Text;

namespace HotChai.Serialization.UnitTest
{
    public static class Extensions
    {
        public static string ToAsciiDumpString(this byte[] bytes)
        {
            const int Width = 8;

            if ((null == bytes) || (bytes.Length == 0))
            {
                return String.Empty;
            }

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < bytes.Length; i += Width)
            {
                bool first = true;

                for (int j = i; j < i + Width; j += 1)
                {
                    if (j >= bytes.Length)
                    {
                        if (first)
                        {
                            first = false;

                            output.Append("  ");
                        }
                        else
                        {
                            output.Append("   ");
                        }
                    }
                    else
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            output.Append("-");
                        }

                        output.Append(BitConverter.ToString(bytes, j, 1));
                    }
                }

                output.Append(" ");

                for (int j = i; j < i + Width; j += 1)
                {
                    if (j >= bytes.Length)
                    {
                        break;
                    }
                    else if (Char.IsControl((char)bytes[j]))
                    {
                        output.Append(".");
                    }
                    else
                    {
                        output.Append((char)bytes[j]);
                    }
                }

                output.Append("\r\n");
            }

            return output.ToString();
        }
    }

    public static class Test
    {
        public static void Output(string format, params object[] args)
        {
            Trace.WriteLine(String.Format(format, args));
        }
    }

    public static class ArrayComparer<T>
    {
        public static bool Equals(
            T[] a,
            T[] b)
        {
            if ((a == null) || (b == null))
            {
                return a == b;
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            Comparer<T> comparer = Comparer<T>.Default;

            for (int i = 0; i < a.Length; ++i)
            {
                if (0 != comparer.Compare(a[i], b[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
