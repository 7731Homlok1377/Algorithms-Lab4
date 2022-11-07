using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Alg
{
    internal class SelectionSortAlgorithm
    {
        public static void Sort(List<string> words)
        {
            int count = words.Count;


            for (int i = 0; i < count - 1; i++)
            {
                
                int minIndex = i;
                for (int j = i + 1; j < count; j++)
                    if (WordAlignment(words[j], words[minIndex]))
                        minIndex = j;

                string temp = words[minIndex];
                words[minIndex] = words[i];
                words[i] = temp;
            }
            PrintList(words);
        }

        
        static void PrintList(List<string> words)
        {
            
            for (int i = 0; i < words.Count; ++i)
            Console.Write(words[i] + " ");
            Console.WriteLine();
        }

        
        

        private static bool WordAlignment(string word1, string word2)
        {
            
            int w1;
            int w2;
            if (word1.Length <= word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    w1 = FindLetter(word1[i]);
                    w2 = FindLetter(word2[i]);
                    if (w1 < w2)
                    {
                        return true;
                    }
                    else if (w1 > w2)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    w1 = FindLetter(word1[i]);
                    w2 = FindLetter(word2[i]);
                    if (w1 < w2)
                    {
                        return true;
                    }
                    else if (w1 > w2)
                    {
                        return false;
                    }
                }

            }
            return false;

        }

        private static int FindLetter(char c) {

            int num = 0;

            for (int i = 0; i < 25; i++)
            {
                if (c == Checker.Alphabe[i])
                {
                    num = i; 
                }
            }
            return num;
        }
    }
}
