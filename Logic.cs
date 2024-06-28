using System;
using System.Collections.Generic;
using System.Linq;

namespace Crucifixion
{
    internal class Logic
    {
        public static List<HashSet<string>> Words { get; set; } = Enumerable.Range(0, 10)
                                                                        .Select(_ => new HashSet<string>())
                                                                        .ToList();

        public static List<int> WordLengths { get; } =
        [
            9, 4, 7, 6, 4, 9, 4, 9, 6, 9
        ];

        public static void Setup()
        {
            List<string> words = FileReader.ReadFile();

            for (int i = 0; i < Words.Count; i++)
            {
                int targetLength = WordLengths[i];

                foreach (var word in words)
                {
                    if (word.Length == targetLength)
                    {
                        Words[i].Add(word);
                    }
                }
            }
        }

        public static void DeleteWordsFrom5()
        {
            HashSet<string> words = new();
            foreach(var word in Words[4])
            {
                if (word[0]=='š')
                {
                    words.Add(word);
                }
            }
            Words[4] = new HashSet<string> (words);
        }

        public static void DeleteWordsFrom9()
        {
            HashSet<string> words = new();
            foreach (var word in Words[8])
            {
                if (word[2] == 'š')
                {
                    words.Add(word);
                }
            }
            Words[8] = new HashSet<string>(words);
        }

       

        public static void Fix(List<int> words, List<int> first, List<int> second)
        {
            var newWords = new List<HashSet<string>>();

            for (int i = 0; i < words.Count; i++)
            {
                newWords.Add([]);
            }

            foreach (var word in Words[words[0]])
            {
                F(words, first, second, 0, [word], newWords);
            }

            for (int i = 0; i < words.Count; i++)
            {
                Words[words[i]] = new HashSet<string>(newWords[i]);
            }

        }

        private static void F(List<int> words, List<int> first, List<int> second, int i, List<string> l, List<HashSet<string>> newWords)
        {
            foreach (var word in Words[words[i+1]])
            {
                if (l[0][first[i]] == word[second[i]]) 
                {
                    l.Add(word);
                    if (l.Count == words.Count)
                    {
                        for (int y=0;y<words.Count;y++)
                        {
                            newWords[y].Add(l[y]); 
                        }
                    }
                    else
                    {
                        F(words, first, second, ++i, new List<string>(l) , newWords);
                        i--;
                    }
                    l.RemoveAt(l.Count - 1);
                }
            }
        }

        public static void RemoveNotNeeded()
        {
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Count == 1)
                {
                    foreach (var Word in Words[i])
                    {
                        for (int y=0;y<Words.Count;y++)
                        {
                            if (i!=y)
                            {
                                Words[y].Remove(Word);
                            }
                        }
                    }
                }
            }
            
        }

        public static void WordsLeft()
        {
            for (int i = 0; i < Words.Count; i++)
            {
                int count = Words[i].Count;
                Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
            }
            var allUniqueWords = new HashSet<string>();
            foreach (var wordSet in Words)
            {
                allUniqueWords.UnionWith(wordSet);
            }
            Console.WriteLine($"Liko unique žodžių: {allUniqueWords.Count}");

            Console.WriteLine("----------------");
        }

        public static void WriteAllWords()
        {
            for(int i = 0;i < Words.Count;i++)
            {
                Console.WriteLine($"iš {i+1} žodžio tokie žodžiai:");
                foreach (var word in Words[i])
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void WriteAnswerWords()
        {
            Console.WriteLine($"iš 1-o žodžio tokie žodžiai:");
            foreach (var word in Words[0])
            {
                Console.WriteLine(char.ToUpper(word[0]) + word.Substring(1));
            }
        }

    }
}

