using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{}
class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press enter key to hide a word or quit to exit the program: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "Quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you memorized the scripture!");
                    break;
                }
            }
        }
    }
}
