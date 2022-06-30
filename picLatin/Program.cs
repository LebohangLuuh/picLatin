using System;
using static System.Console;

namespace picLatin
{
    class Program
    {
        static void Main(string[] args)
        {
             string word;
            const string SUFFIX = "ay";

            Write("Please enter a word : ");
            word = ReadLine();

            WriteLine("The picLatin version of the word is : ");
            WriteLine(word.Substring(1, word.Length-1) + word.Substring(0,1) + SUFFIX); 

            ReadKey();
        }
       
    }
}
