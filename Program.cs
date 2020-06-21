using System;

namespace ExtensionsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = "52";
            int number = numberString.ToInt32();

            Console.WriteLine(number);
        }
    }
}
