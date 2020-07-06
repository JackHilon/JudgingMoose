using System;

namespace JudgingMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            // Judging Moose
            // https://open.kattis.com/problems/judgingmoose 
            // simple program 

            var moose = EnterLine();
            Console.WriteLine(GetMoose(moose));
        }
        private static string GetMoose(int[] arr)
        {
            int left = arr[0];
            int right = arr[1];
            if (left == 0 && right == 0)
                return "Not a moose";
            else if (left == right)
                return $"Even {2 * left}";
            else
                return $"Odd {2 * Math.Max(left,right)}";
        }
        private static int[] EnterLine()
        {
            int[] res = new int[2];
            string[] arr = new string[2];
            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                    if (res[i] < 0 || res[i] > 20)
                        throw new ArgumentException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterLine();
            }
            return res;
        }
    }
}
