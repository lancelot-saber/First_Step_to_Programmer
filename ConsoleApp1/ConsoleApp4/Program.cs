using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Result = 0;
            Result = (N - 2) * 180;
            Console.WriteLine(Result);
        }
    }

    class Sumo
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int k = S.Length;
            int remainChance = 15 - k;
            if (remainChance >= 0)
            {
                string SR = S.Replace("o", "");
                int win = S.Length - SR.Length;
                if(win+remainChance>=8)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("Wrong Records");
            }
        }
    }


    //class Solution
    //{
    //    public LinkedListNode<int> mergeTwoLists(LinkedListNode<int> l1,LinkedListNode<int> l2)
    //    {
    //        LinkedList<int> ll=new LinkedList<int>( );
    //        ll.

    //        if (l1 == null)
    //        {
    //            return l2;
    //        }
    //        else if (l2 == null)
    //        {
    //            return l1;
    //        }
    //        else if (l1.Value < l2.Value)
    //        {
    //            l1.Next = mergeTwoLists(l1.Next, l2);
    //            return l1;
    //        }
    //        else
    //        {
    //            l2.Next = mergeTwoLists(l1, l2.Next);
    //            return l2;
    //        }

            
    //    }
    //}

}
