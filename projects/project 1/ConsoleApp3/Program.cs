using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək

            Console.WriteLine("yazi daxil et");
            string text = Console.ReadLine();

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    result += text[i];

                
                }
            
            
            
            }


            Console.WriteLine(result);




        }
    }
}
