using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = LongestPalindrome("azaaaaa");

            Console.WriteLine(ans);
            Console.ReadLine();
        }
        public static string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1)
            {
                return "";
            }
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            if (end > s.Length - 1)
            {
                return s.Substring(start, s.Length - 1);
            }
            else
            {
                return s.Substring(start, end - start + 1);
            }          
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s.ElementAt(L) == s.ElementAt(R))
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
