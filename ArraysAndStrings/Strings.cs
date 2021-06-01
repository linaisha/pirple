using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysAndStrings
{
    public class Strings
    {
        static void Main(string[] args)
        {
            // modifying strings

            // string class allows us to use replace and remove
            string testString = "Hello, my name is Elisa";

            // Replace can be used to replace words with others
            // replace replaces every instance of that character/word
            string resultString = testString.Replace("Elisa", "Luisa");
            Console.WriteLine(testString);
            Console.WriteLine(resultString);
            // replace can be used a different way
            string resString2 = testString.Replace("E", "i");
            Console.WriteLine(resString2);

            // remove removes a list of characters from a starting point as an index
            string removeString = testString.Remove(17,6);
            Console.WriteLine(removeString);

            // appending string
            testString = testString + " and I am a CS major";
            // problems
            // we create a new instance of a string everytime we modify which causes our program to run slower
            // and use more memmory than needed
        }
    }
}