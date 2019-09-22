using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, k1 = 0, n;
            string[] a = Console.ReadLine().Split(' ');
            string[] a1 = Console.ReadLine().Split(' ');
            if (a.Length > a1.Length)
                n = a.Length;
            else
                n = a1.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] == a1[i])
                {
                    k++;
                    if (a[i] != a1[i])
                    {
                        break;
                    }
                }
            }
            for (int i = n - 1; i > 0; i--)
            {
                if (a[i] == a1[i])
                {
                    k1++;
                    if (a[i] != a1[i])
                    {
                        break;
                    }
                }
            }
            if (k > k1)
            {
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(k1);
            }
            Console.ReadKey();
        }
    }
}