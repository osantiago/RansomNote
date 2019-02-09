using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string words = "two times three is not four";
            string ransom = "two times two is four";

            string[] magazine = words.Split(' ');
            string[] note = ransom.Split(' ');

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach (var item in magazine)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item].Add(item);
                }
                else
                    dictionary.Add(item, new List<string> { item });
            }

            foreach (var str in note)
            {
                if (dictionary.ContainsKey(str))
                {
                    dictionary[str].Remove(str);
                    if (dictionary[str].Count == 0)
                    {
                        dictionary.Remove(str);
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");

        }
    }
}
