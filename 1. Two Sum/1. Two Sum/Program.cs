using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi kaç elemanlı giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aranan toplamı giriniz");
            int aranan = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine($"Dizinin {i} . elemanını giriniz :");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }        

            int[] sonuc = TwoSum(dizi, aranan);
            foreach (int i in sonuc)
            {
                Console.WriteLine(i);

            }
            
        }

        static int[] TwoSum(int[] nums,int target)
        {
            int[] index = new int[2];
            int boyut = nums.Length;
            Array.Sort(nums);
            //for (int i = 0; i < nums.Length / 2; i++)
            //{
            //    int j = i;
            //    int sayi1 = nums[i];
            //    int sayi2 = nums[boyut - 1 - j];
            //    if(sayi1 + sayi2 == target)
            //    { 
            //        index[0] = i;
            //        index[1] = boyut - 1 - i;
            //        break;
            //    }
            //    else if(sayi1+ sayi2 < target)
            //    {
            //        i++;
            //    }
            //    else if(sayi1+sayi2> target)
            //    {
            //        j++;
            //    }
            //}
            bool flag = false;
            int i = 0, j = 0;
            while (!flag)
            {                
                int sayi1 = nums[i];
                int sayi2 = nums[boyut - 1 - j];
                if (sayi1 + sayi2 == target)
                {
                    index[0] = i;
                    index[1] = boyut - 1 - i;
                    break;
                }
                else if (sayi1 + sayi2 < target)
                {
                    i++;
                }
                else if (sayi1 + sayi2 > target)
                {
                    j++;
                }

            }



            return index;
        }
    }
}
