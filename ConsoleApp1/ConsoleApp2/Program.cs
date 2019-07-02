using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            List<int> P = new List<int>();
            List<string[]> S = new List<string[]>();
            N = int.Parse(Console.ReadLine());
            string[] str;

            for(int i = 0; i < N; i++)
            {
                str = Console.ReadLine().Split(' ');
                Array.Resize(ref str, 3);
                str[2] = (i + 1).ToString();
                S.Add(str);
            }
            S.Sort((a, b) => a[0].CompareTo(b[0]) != 0 ? a[0].CompareTo(b[0]) : int.Parse(b[1]) - int.Parse(a[1]));
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(int.Parse(S[i][2]));
            }
        }

    }
}
