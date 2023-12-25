using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            //Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            //(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

            int[] eded_sayi = new int[2];


            for (int i = 0; i < eded_sayi.Length; i++)
            {

                Console.WriteLine("eded daxil edin ");
                eded_sayi[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.Write("emeliyyat daxil et (+, -, *, /): ");
            char emeliyyat = Convert.ToChar(Console.ReadLine());

            
            switch (emeliyyat)
            {
                case '+':
                    Console.WriteLine($"Result: {eded_sayi[0] + eded_sayi[1]}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {eded_sayi[0] - eded_sayi[1]}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {eded_sayi[0] * eded_sayi[1]}");
                    break;
                case '/':
                   
                    if (eded_sayi[1] != 0)
                    {
                        Console.WriteLine($"Result: {1.0 * eded_sayi[0] / eded_sayi[1]}");
                    }
                    else
                    {
                        Console.WriteLine("0a bolunme yoxdur");
                    }
                    break;
                default:
                    Console.WriteLine("yanlis emeliyyat ");
                    break;




            }
        }
}   }
