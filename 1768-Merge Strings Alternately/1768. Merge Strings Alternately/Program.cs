using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1768.Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk inputu girin:");
            string word1 = Console.ReadLine();

            Console.WriteLine("2. inputu girin:");
            string word2 = Console.ReadLine();

            string sonuc = MergeAlternately(word1, word2);
            Console.WriteLine(sonuc);
        }


        static string MergeAlternately(string word1, string word2)
        {
            int word1Length = word1.Length;
            int word2Length = word2.Length;
            int maxLength = Math.Max(word1Length, word2Length);

            char[] merge = new char[word1Length + word2Length];
            int index = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1Length)
                {
                    merge[index++] = word1[i]; 
                }
                if (i < word2Length)
                {
                    merge[index++] = word2[i];
                }
            }

            return new string(merge); 
        }



    }

}

