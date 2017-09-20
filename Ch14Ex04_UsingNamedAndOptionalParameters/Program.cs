﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Ex04_UsingNamedAndOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "'twas brillig, and the slithy toves did gyre and gimble in the wabe:";
            List<string> words;

            words = WordProcessor.GetWords(sentence);
            Console.WriteLine("Original sentence:");
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(' ');

            }
            Console.WriteLine('\n');

            words = WordProcessor.GetWords(sentence, reverseWords: true, capitalizeWords: true);
            Console.WriteLine("Sentence with capitalized and reversed words:");
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(' ');

            }
            Console.ReadKey();
        }
    }
}
