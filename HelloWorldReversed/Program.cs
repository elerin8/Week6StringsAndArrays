using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, world!" tagurpidi

            Console.WriteLine("Hello, world!");
            string sentence = ("Hello, world!");

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }
        }
    }
}
