using System;
using System.Collections;
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
                        
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                text = sr.ReadLine();
            }
            GetWordsList(text);
        }

        //получаем сам список слов
        public static List<string> GetWordsList(string line) {

            string[] data = line.Split(" ");

            
            List<string> list = new List<string>();

            

            foreach (string word in data) {

                string result = "";
                
                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (Char.ToLower(word[i]) == Alphabe[j])
                        {
                            result = result + word[i];
                        }
                        continue;

                    }
                }

                list.Add(result);
               
            }
            return list;
            //SelectionSortAlgorithm.Sort(list);
        }

        //получаем индекс символа и по нему сравниваем какая буква стоит раньше в алфавите
        public static int FindLetter(char c)
        {

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

        
        public static void CountWords(List<string> words) {

            IEnumerable<string> enumerable = words as IEnumerable<string>;
            var stringGroups = enumerable.GroupBy(s => s);
            foreach (var stringGroup in stringGroups)
                Console.WriteLine("{0}  {1}", stringGroup.Key, stringGroup.Count());
            //List<CountWords> list = new List<CountWords>();
            //for (int i = 0; i < words.Count; i++)
            //{
            //    if (list[i].Word  == words[i])
            //    {
            //        list[i].Count++;
            //    }

            //}

        }
    }
}
