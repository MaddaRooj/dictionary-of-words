using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Excited", "The feeling of students when they learn something new");
            wordsAndDefinitions.Add("Overwhelmed", "The feeling of students when they are completing career dev work");
            wordsAndDefinitions.Add("Revitalized", "The feeling when you start a new career path");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            // Console.WriteLine(wordsAndDefinitions["Overwhelmed"]);
            // Console.WriteLine(wordsAndDefinitions["Revitalized"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
            // };

            // PART 2 - DICTIONARY ABOUT WORDS--------------------------------------------------------------------------------------------------------

                // Make a new list
                List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

                // Create dictionary to represent a few words
                Dictionary<string, string> awesomeWord = new Dictionary<string, string>();
                Dictionary<string, string> excitedWord = new Dictionary<string, string>();
                Dictionary<string, string> overwhelmedWord = new Dictionary<string, string>();
                Dictionary<string, string> revitalizedWord = new Dictionary<string, string>();

                // Add each of the 4 bits of data about the word to the Dictionary
                excitedWord.Add("word", "excited");
                excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
                excitedWord.Add("part of speech", "adjective");
                excitedWord.Add("example sentence", "Graduating from NSS makes me very excited.");
                
                awesomeWord.Add("word", "awesome");
                awesomeWord.Add("definition", "Addam Joor");
                awesomeWord.Add("part of speech", "adjective");
                awesomeWord.Add("example sentence", "Addam sure is awesome.");

                overwhelmedWord.Add("word", "overwhelm");
                overwhelmedWord.Add("definition", "to bury of drown beneath a huge mass");
                overwhelmedWord.Add("part of speech", "verb");
                overwhelmedWord.Add("example sentence", "The instructors at NSS take pleasure in overwheming students.");

                revitalizedWord.Add("word", "revitalize");
                revitalizedWord.Add("definition", "rejuvenate, reinvigorate, to renew enthusiasm");
                revitalizedWord.Add("part of speech", "verb");
                revitalizedWord.Add("example sentence", "NSS serves to revitalize the careers of many students.");

                // Add Dictionary to your `dictionaryOfWords` list
                dictionaryOfWords.Add(awesomeWord);
                dictionaryOfWords.Add(excitedWord);
                dictionaryOfWords.Add(overwhelmedWord);
                dictionaryOfWords.Add(revitalizedWord);

                /*
                    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                    Example output for one word in the list of dictionaries:
                        word: excited
                        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                        part of speech: adjective
                        example sentence: I am excited to learn C#!
                */

                // Iterate the List of Dictionaries
                foreach (Dictionary<string, string> word in dictionaryOfWords) 
                {
                    // Iterate the KeyValuePairs of the Dictionary
                    foreach (KeyValuePair<string, string> wordData in word)
                    {
                        Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                    }
                        Console.WriteLine($" ");
                }
        }
    }
}
