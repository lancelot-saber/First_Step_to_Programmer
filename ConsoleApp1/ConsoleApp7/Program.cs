using System;


namespace ConsoleApp7
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var strnums = "5 4 3".Split(' ');
    //        //var strnums = Console.ReadLine().Split(' ');
    //        //int.TryParse(strnums[0], out int num1);
    //        //int.TryParse(strnums[1], out int num2);
    //        //int.TryParse(strnums[2], out int num3);
    //        int num1 = int.Parse(strnums[0]);
    //        int num2 = int.Parse(strnums[1]);
    //        int num3 = int.Parse(strnums[2]);


    //        int temp;
    //        if (num1 > num2) { temp = num1; num1 = num2; num2 = temp; }
    //        if (num2 > num3) { temp = num2; num2 = num3; num3 = temp; }
    //        if (num1 > num3) { temp = num1; num1 = num3; num3 = temp; }


    //        var res = num1 + num2;

    //        Console.WriteLine(res);
    //        Console.ReadLine();

    //    }
    //}


    class Solution
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //var strnums = Console.ReadLine().Split(' ');
            int N = int.Parse("3");
            var strnums = "1 2 3".Split(' ');
            var weights = Array.ConvertAll(strnums, s => int.Parse(s));
            int total = 0; int s1 = 0; int option1 = 0; //int option2 = 0;
            foreach (int w in weights)
            {
                total += w;
            }
            for(int i = 0; i < weights.Length; i++)
            {             
                s1 += weights[i];
                if (s1 < total / 2 && total / 2 <= s1 + weights[i + 1])
                {
                    option1 = Math.Min(Math.Abs(total - 2 * s1), Math.Abs(2 * (s1 + weights[i + 1]) - total));
                    break;
                }               
            }
            Console.WriteLine(option1);
            Console.ReadLine();
        }
    }
}
