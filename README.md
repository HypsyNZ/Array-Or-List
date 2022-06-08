Type  | Time | Len
------|------|-------
Array | 2ms |  500000 
List  | 1ms |  255000
Array Append | 17950ms | 55000

```cs
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
            Console.WriteLine("List Time: " + time.ElapsedMilliseconds + " | Count: " + listLongs.Count());
            //List  Time: 1ms    Count : 255000

            time.Restart();
            time.Start();
            for (long i = 1; i < 500000; i++)
            {
                longs[i] = i * 200;
            }
            Console.WriteLine("Array Time: " + time.ElapsedMilliseconds + " | Length: " + longs.Length);
            //Array Time: 2ms Length: 500000 (Unrealistic Data)
            
            time.Restart();
            time.Start();
            for (int i = 50000000; i < 50055000; i++)
            {
                longs2 = longs2.Append(i).ToArray();
            }
            Console.WriteLine("Array Append Time: " + time.ElapsedMilliseconds + " | Length: " + longs2.Length);
            //Array Time: 17950ms Length: 55000
            
            Console.ReadLine();
        }
    }
```