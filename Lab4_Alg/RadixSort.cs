using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Alg
{
    //Поразрядная сортировка
    internal class RadixSort
    {
        
        static int[] ConvertToInt(string[] words)
        {

            string word = "";

            int[] result = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                word = "";
                foreach (var item in words[i])
                {
                    word = word + Checker.FindLetter(Char.ToLower(item));
                }

                result[i] = int.Parse(word);
            }
            return result;
        }
        

        public static void sorting(string[] words, int range, int length)
        {

            int[] arr = ConvertToInt(words);
            ArrayList[] arlist = new ArrayList[range]; //попробовать for создать экземпляры
            for (int i = 0; i < range; i++)
            {
                arlist[i] = new ArrayList();
            }


            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                    arlist[temp].Add(words[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k] = (int)lists[i][j];
                        words[k] = arlist[i][j].ToString();
                        k++;
                    }
                }
                for (int i = 0; i < range; ++i)
                {
                    lists[i].Clear();
                    arlist[i].Clear();
                }
                
                    
            }
        }
    }
}
