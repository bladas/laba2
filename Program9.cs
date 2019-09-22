using System;


namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            foreach (var i in array)
            {
                Console.WriteLine($"{i} -> {i - 97}");
            }
            Console.ReadKey();
        }
    }
}