using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using Crucifixion;

class Program
{
    static void Main()
    {
        List<string> words = FileReader.ReadFile();
        Console.WriteLine($"Geri žodžiai: {words.Count}");

        List<HashSet<string>> goodWords = ListCreator.CreateList();

        //9
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].CheckWord(9,2,'š'))
            {
                goodWords[8].Add(words[i]);
                //Console.WriteLine(words[i]);
            }
        }

        

        Console.WriteLine("----------");


        //3
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].CheckWord(3))
            {
                bool truth = false;
                foreach(var word in goodWords[8])
                {
                    if (words[i][4] == Char.ToLowerInvariant(word[0]))
                    {
                        truth= true;
                        goodWords[2].Add(words[i]);
                        break;
                    }
                }
                
                if (!truth)
                {
                    words.RemoveAt(i);
                    i--;
                }
            }
        }



        //foreach (var word in goodWords[2])
        //{
        //    Console.WriteLine(word);
        //}


        Console.WriteLine($"Liko Gerų žodžių: {words.Count}");
        Console.WriteLine("----------");


        //5
        for (int i=0; i<words.Count; i++)
        {
            if (words[i].CheckWord(5,0,'Š'))
            {
                goodWords[4].Add(words[i]);
            }
        }
        //6
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].CheckWord(6))
            {
                goodWords[5].Add(words[i]);
            }
        }

        //2
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].CheckWord(2))
            {
                goodWords[1].Add(words[i]);
            }
        }

        //10

       


        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].CheckWord(1))
            {
                goodWords[0].Add(words[i]);
            }
            if (words[i].CheckWord(4))
            {
                goodWords[3].Add(words[i]);
            }
            if (words[i].CheckWord(7))
            {
                goodWords[6].Add(words[i]);
            }
            if (words[i].CheckWord(8))
            {
                goodWords[7].Add(words[i]);
            }
        }

        goodWords[0].Remove("Pavarklas");
        goodWords[5].Remove("Pavarklas");
        goodWords[7].Remove("Pavarklas");
        goodWords[9] = ["Pavarklas"];

        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }

        Console.WriteLine("-čia?3?---");

        HashSet <string> s1 = new HashSet<string>();
        HashSet <string> s2 = new HashSet<string>();
        HashSet <string> s4 = new HashSet<string>();
        HashSet <string> s5 = new HashSet<string>();

        foreach (var word in goodWords[9])
        {
            foreach (var word2 in goodWords[1]) { if (word[1] == word2[1]) { s1.Add(word2); } };
            foreach (var word3 in goodWords[2]) { if (word[3] == word3[6]) { s2.Add(word3); } };
            foreach (var word5 in goodWords[4]) { if (word[5] == word5[2]) { s4.Add(word5); } };
            foreach (var word6 in goodWords[5]) { if (word[7] == word6[8]) { s5.Add(word6); } };

        }

        goodWords[1] = new HashSet<string>(s1);
        goodWords[2] = new HashSet<string>(s2);
        goodWords[4] = new HashSet<string>(s4);
        goodWords[5] = new HashSet<string>(s5);

        
        

        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }

        Console.WriteLine("----------");

        HashSet<string> s8 = new HashSet<string>();

        foreach (var word in goodWords[7])
        {
            foreach(var word1 in goodWords[0])
            {
                if (word[2] == word1[7])
                {
                    foreach (var word3 in goodWords[2])
                    {
                        if (word[4] == word3[2])
                        {
                            foreach (var word4 in goodWords[3])
                            {
                                if (word[6] == word3[5])
                                {
                                    foreach (var word6 in goodWords[5])
                                    {
                                        if (word[8] == word6[4])
                                        {
                                            s8.Add(word);
                                            //Console.WriteLine(s8.Count);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

       

        Console.WriteLine("---čia?4?---");


        HashSet<string> s0 = new HashSet<string>();
        s2 = new HashSet<string>();
        HashSet<string> s3 = new HashSet<string>();
        s5 = new HashSet<string>();


        foreach (var word in goodWords[7])
        {
            foreach (var word1 in goodWords[0]) { if (word[2] == word1[7]) { s0.Add(word1); } };
            foreach (var word3 in goodWords[2]) { if (word[4] == word3[2] && goodWords[2].Contains(word3)) { s2.Add(word3); } };
            foreach (var word4 in goodWords[3]) { if (word[6] == word4[5]) { s3.Add(word4); } };
            foreach (var word6 in goodWords[5]) { if (word[8] == word6[4] && goodWords[5].Contains(word6)) { s5.Add(word6); } };
        }

        goodWords[0] = new HashSet<string>(s0);
        goodWords[2] = new HashSet<string>(s2);
        goodWords[3] = new HashSet<string>(s3);
        goodWords[5] = new HashSet<string>(s5);




        Console.WriteLine("------");

        


        HashSet<string> s6 = new HashSet<string>();
        HashSet<string> s7 = new HashSet<string>();
        s8 = new HashSet<string>();
        HashSet<string> s9 = new HashSet<string>();

        foreach (var word in goodWords[5])
        {
            foreach (var word7 in goodWords[6]) { if (word[1] == word7[2]) { s6.Add(word7);   } };
            foreach (var word8 in goodWords[7]) { if (word[4] == word8[8]) { s7.Add(word8); } };
            foreach (var word9 in goodWords[8]) { if (word[6] == word9[4] && goodWords[8].Contains(word9)) { s8.Add(word9); } };
            foreach (var word10 in goodWords[9]) { if (word[8] == word10[7] ) { s9.Add(word10); } };

        }

        goodWords[6] = new HashSet<string>(s6);
        goodWords[7] = new HashSet<string>(s7);
        goodWords[8] = new HashSet<string>(s8);
        goodWords[9] = new HashSet<string>(s9);

       

        Console.WriteLine("------");

        s7 = new HashSet<string>();
        s8 = new HashSet<string>();
        s9 = new HashSet<string>();

        foreach (var word in goodWords[2])
        {
            foreach (var word8 in goodWords[7]) { if (word[2] == word8[4] && goodWords[7].Contains(word8)) { s7.Add(word8); } };
            foreach (var word9 in goodWords[8]) { if (word[4] == Char.ToLowerInvariant(word9[0]) && goodWords[8].Contains(word9)) { s8.Add(word9); } };
            foreach (var word10 in goodWords[9]) { if (word[6] == word10[3] && goodWords[9].Contains(word10) && goodWords[9].Contains(word10)) { s9.Add(word10); } };
        }

        goodWords[7] = new HashSet<string>(s7);
        goodWords[8] = new HashSet<string>(s8);
        goodWords[9] = new HashSet<string>(s9);



        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }

        

        Console.WriteLine("------");

         s2 = new HashSet<string>();
         s5 = new HashSet<string>();
         

        foreach (var word in goodWords[8])
        {
            foreach (var word3 in goodWords[2]) { if (Char.ToLowerInvariant(word[0]) == word3[4]) { s2.Add(word3); } };
            foreach (var word6 in goodWords[5]) { if (word[4] == word6[6]) { s5.Add(word6); } };
        }

        goodWords[2] = new HashSet<string>(s2);
        goodWords[5] = new HashSet<string>(s5);
       

        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }

        Console.WriteLine("----------");

        HashSet<string> allUniqueWords = new HashSet<string>();
        foreach (var wordSet in goodWords)
        {
            allUniqueWords.UnionWith(wordSet);
        }

        // Step 2: Write the unique words to a CSV file
        string filePath = "uniqueWords.csv";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string word in allUniqueWords)
            {
                writer.WriteLine(word);
            }
        }

        Console.WriteLine($"Unique words have been written to {filePath}");

        //10

        s9 = new HashSet<string>();

        foreach (var word in goodWords[9])
        {
                foreach (var word2 in goodWords[1])
                {
                    if (word[1] == word2[1])
                    {
                        foreach (var word3 in goodWords[2])
                        {
                            if (word[3] == word3[6])
                            {
                                foreach (var word5 in goodWords[4])
                                {
                                    if (word[5] == word5[2])
                                    {
                                        foreach (var word6 in goodWords[5])
                                        {
                                            if (word[7] == word6[8])
                                            {
                                                s9.Add(word);
                                            }
                                        }
                                    }
                                }
                            }
                    }
                }
            }
        }

        goodWords[9] = new HashSet<string>(s9);

        //9,4,7,6,4,9,4,9,6,9
        //0,1,2,3,4,5,6,7,8,9
        string w = "";

        foreach (var word in goodWords[9])
        {
            Console.WriteLine(word);
            w = word;
        }
        



        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }



        

        Console.WriteLine("-----iii-----");

         s1 = new HashSet<string>();
         s2 = new HashSet<string>();
         s4 = new HashSet<string>();
        s5 = new HashSet<string>();

        foreach (var word in goodWords[9])
        {
            foreach (var word2 in goodWords[1]) { if (word[1] == word2[1]) { s1.Add(word2); } };
            foreach (var word3 in goodWords[2]) { if (word[3] == word3[6]) { s2.Add(word3); } };
            foreach (var word5 in goodWords[4]) { if (word[5] == word5[2]) { s4.Add(word5); } };
            foreach (var word6 in goodWords[5]) { if (word[7] == word6[8]) { s5.Add(word6); } };
        }

        

        goodWords[1] = new HashSet<string>(s1);
        goodWords[2] = new HashSet<string>(s2);
        goodWords[4] = new HashSet<string>(s4);
        goodWords[5] = new HashSet<string>(s5);

        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }

        Console.WriteLine("----------");




        s8 = new HashSet<string>();

        foreach (var word in goodWords[7])
        {
            foreach (var word1 in goodWords[0])
            {
                if (word[2] == word1[7])
                {
                    foreach (var word3 in goodWords[2])
                    {
                        if (word[4] == word3[2])
                        {
                            foreach (var word4 in goodWords[3])
                            {
                                if (word[6] == word3[5])
                                {
                                    foreach (var word6 in goodWords[5])
                                    {
                                        if (word[8] == word6[4])
                                        {
                                            s8.Add(word);
                                            //Console.WriteLine(s8.Count);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("---čia?4?---");


        s0 = new HashSet<string>();
        s2 = new HashSet<string>();
        s3 = new HashSet<string>();
        s5 = new HashSet<string>();

        foreach (var word in goodWords[7])
        {
            foreach (var word1 in goodWords[0]) { if (word[2] == word1[7]) { s0.Add(word1); } };
            foreach (var word3 in goodWords[2]) { if (word[4] == word3[2] && goodWords[2].Contains(word3)) { s2.Add(word3); } };
            foreach (var word4 in goodWords[3]) { if (word[6] == word4[5]) { s3.Add(word4); } };
            foreach (var word6 in goodWords[5]) { if (word[8] == word6[4] && goodWords[5].Contains(word6)) { s5.Add(word6); } };

        }

        goodWords[0] = new HashSet<string>(s0);
        goodWords[2] = new HashSet<string>(s2);
        goodWords[3] = new HashSet<string>(s3);
        goodWords[5] = new HashSet<string>(s5);



        for (int i = 0; i < goodWords.Count; i++)
        {
            int count = goodWords[i].Count;
            Console.WriteLine($"Liko žodžių žodžiui: {i + 1}: {count}");
        }


        Console.WriteLine("---5?---");

        allUniqueWords = new HashSet<string>();
        foreach (var wordSet in goodWords)
        {
            allUniqueWords.UnionWith(wordSet);
        }

        Console.WriteLine("liko skirtingų žodžių: " +allUniqueWords.Count.ToString());


        s7 = new HashSet<string>();
        s8 = new HashSet<string>();
        s9 = new HashSet<string>();

        foreach (var word in goodWords[2])
        {
            foreach (var word8 in goodWords[7]) { if (word[2] == word8[4] && goodWords[7].Contains(word8)) { s7.Add(word8); } };
            foreach (var word9 in goodWords[8]) { if (word[4] == Char.ToLowerInvariant(word9[0]) && goodWords[8].Contains(word9)) { s8.Add(word9); } };
            foreach (var word10 in goodWords[9]) { if (word[6] == word10[3] && goodWords[9].Contains(word10) && goodWords[9].Contains(word10)) { s9.Add(word10); } };
        }

        goodWords[7] = new HashSet<string>(s7);
        goodWords[8] = new HashSet<string>(s8);
        goodWords[9] = new HashSet<string>(s9);

        Console.WriteLine("liko skirtingų žodžių: " + allUniqueWords.Count.ToString());

    }
}

//žiauriai ištestuoti : 8,10
//gerai ištestuoti: 6, 3
//db 9
