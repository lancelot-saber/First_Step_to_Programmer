using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Ex2
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var rests = new List<Restaurant>();

            for (int i = 1; i <= num; i++)
            {
                var cont = Console.ReadLine();
                var split = cont.Split(' ');
                rests.Add(new Restaurant() { City = split[0], Point = int.Parse(split[1]), Index = i });
            }

            foreach (var rest in rests.OrderBy(e => e.City).ThenByDescending(e => e.Point))
                Console.WriteLine(rest.Index);
        }

        class Restaurant
        {
            public string City { get; set; }
            public int Point { get; set; }
            public int Index { get; set; }
        }
    }


    class Program
    {
        static int n;
        static int m;
        static bool[,] d;
        static int[] p;

        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split();
            n = int.Parse(nm[0]);
            m = int.Parse(nm[1]);

            d= new bool[m, n];
            for(int i = 0; i < m; i++)
            {
                var k = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 1; j <= k[0]; j++)
                {
                    d[i, k[j] - 1] = true;
                }
            }

            p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var ans = 0;
            for(int i = 0; i < Math.Pow(2, n); i++)
            {
                if (all(i)) ans++;
            }

            Console.WriteLine(ans);
        }

        static bool all(int x)
        {
            for(int i = 0; i < m; i++)
            {
                var count = 0;
                for(int j = 0; j < n; j++)
                {
                    if (d[i, j] && (x >> j & 1) == 1)
                    {
                        count++;
                    }
                }
                if (count % 2 != p[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
