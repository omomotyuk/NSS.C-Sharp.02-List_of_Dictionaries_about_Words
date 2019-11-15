using System;
using System.Collections.Generic;

namespace _04.List_of_Dictionaries_about_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word","excited");
            excitedWord.Add("definition","having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech","adjective");
            excitedWord.Add("example sentence","I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);
            //excitedWord.Clear();

            Dictionary<string, string> excitedWord2 = new Dictionary<string, string>();

            // create another Dictionary and add that to the list
            excitedWord2.Add("word","second word");
            excitedWord2.Add("definition","second definition");
            excitedWord2.Add("part of speech","second part of speech");
            excitedWord2.Add("example sentence","second example sentence");

            dictionaryOfWords.Add(excitedWord2);
            //excitedWord.Clear();

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            //Console.WriteLine( dictionaryOfWords.Count );

            // Iterate the List of Dictionaries
            foreach ( Dictionary<string, string> word in dictionaryOfWords )
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach ( KeyValuePair<string,string> wordData in word )
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
                Console.Write("\n");
            }
        }


        static Dictionary<string, string> newWord( List<string> record )
        {
            Dictionary<string, string> word = new Dictionary<string, string>();

            word.Add("word","");
            word.Add("definition","");
            word.Add("part of speech","");
            word.Add("example sentence","");

            return word;
        }
    }
}
