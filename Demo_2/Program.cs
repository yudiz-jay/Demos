using System;

namespace Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter size of an array");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(num);
                Array.Reverse(num);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(num[i]+" ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("General exception", ex.Message);

                throw;
            }

        }
    }
}
