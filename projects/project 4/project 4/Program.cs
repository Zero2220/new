using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Verilmiş yazının əvvəlindəki boşluqlar 
            //silinmiş bir string düzəldən proqram 
            //(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.


            Console.WriteLine("yazini daxil edin ");
            string yazi = Console.ReadLine();

            string duz_yazi = "";

            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] != ' ')
                {

                    duz_yazi += yazi[i];
                }


            } 

            Console.WriteLine(duz_yazi); 
        }
    }
}
