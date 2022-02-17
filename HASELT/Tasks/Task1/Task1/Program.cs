using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextCalculator a = new TextCalculator();
            while (true)
            {
                var str = Console.ReadLine();
                Console.WriteLine(a.Add(str));
            }
                       
        }
    }
}
