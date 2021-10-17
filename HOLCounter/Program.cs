using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            


            Console.WriteLine("Hello world!");
            string words = ("hello world!");
            
            

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'h')
                {
                    hCounter++;

                }
            }

            if (hCounter != 1)
            {

                Console.WriteLine($"Lauses 'Hello world!' on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello world!' on {hCounter} 'h' täht.");
            }

           

            for (int o = 0; o < words.Length; o++)
            {
                if (words[o] == 'o')
                {
                    oCounter++;

                }
            }
         


            if (oCounter != 1)
            {

                Console.WriteLine($"Lauses 'Hello world!' on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello world!' on {oCounter} 'o' täht.");
            }
            

            for (int l = 0; l < words.Length; l++)
            {
                if (words[l] == 'l')
                {
                    lCounter++;

                }
            }


            if (lCounter != 1)
            {

                Console.WriteLine($"Lauses 'Hello world!' on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello world!' on {lCounter} 'l' täht.");
            }
        
        
        }
    }
}
