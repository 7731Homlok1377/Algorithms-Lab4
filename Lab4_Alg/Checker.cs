using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Alg
{
    internal class Checker
    {
        public static string Alphabe = "abcdefghijklmnopqrstuvwxyz";

        public static void WorkingFile(string data)
        {

            string text;

            using (StreamWriter sw = new StreamWriter("text.txt", false))
            {
                sw.Write(data);
            }

            using (StreamReader sr = new StreamReader("text.txt"))
            {
                text = sr.ReadLine();
            }
            
        }

        public static void GetWordsList(string line) {

            string[] data = line.Split(" ");

            
            List<string> list = new List<string>();

            

            foreach (string word in data) {

                string result = "";

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (word[i] == Alphabe[j])
                        {
                            result = result + word[i];
                        }
                        continue;

                    }
                }

                list.Add(result);
               
            }

            SelectionSortAlgorithm.Sort(list);
        }

        
        
    }
}
