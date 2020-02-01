using System;

namespace UserInputMichaelHansen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Michael Hansen");
            Console.WriteLine("Type what you want say, then press enter");

            string testString;

            testString = Console.ReadLine();
            Console.WriteLine("You typed:  ");
            Console.WriteLine(testString);

        }
    }
}
