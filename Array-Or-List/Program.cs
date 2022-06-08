/*
*MIT License
*
*Copyright (c) 2022 S Christison
*
*Permission is hereby granted, free of charge, to any person obtaining a copy
*of this software and associated documentation files (the "Software"), to deal
*in the Software without restriction, including without limitation the rights
*to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
*copies of the Software, and to permit persons to whom the Software is
*furnished to do so, subject to the following conditions:
*
*The above copyright notice and this permission notice shall be included in all
*copies or substantial portions of the Software.
*
*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
*IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
*FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
*AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
*LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
*OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
*SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Array_Or_List
{
    internal class Program
    {
        private static long[] longs = new long[500000];
        private static long[] longs2 = { };
        private static List<long> listLongs = new List<long> { };

        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Stopwatch time = new Stopwatch();

            time.Start();
            for (int f = 50000000; f < 50255000; f++)
            {
                listLongs.Add(f);
            }

            //List  Time: 1ms    Count : 255000
            Console.WriteLine("List Time: " + time.ElapsedMilliseconds + " | Count: " + listLongs.Count());

            time.Restart();
            time.Start();
            for (long i = 1; i < 500000; i++)
            {
                longs[i] = i * 200;
            }

            //Array Time: 2ms Length: 500000 (Unrealistic Data)
            Console.WriteLine("Array Time: " + time.ElapsedMilliseconds + " | Length: " + longs.Length);

            time.Restart();
            time.Start();
            for (int i = 50000000; i < 50055000; i++)
            {
                longs2 = longs2.Append(i).ToArray();
            }

            //Array Time: 17950ms Length: 55000
            Console.WriteLine("Array Append Time: " + time.ElapsedMilliseconds + " | Length: " + longs2.Length);

            Console.ReadLine();
        }
    }
}
