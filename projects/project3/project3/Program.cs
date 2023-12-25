using System;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sozlerin sayini daxil edin ");
            int words = Convert.ToInt32(Console.ReadLine());

            string[] list = new string[words];

            for (int i = 0; i < words; i++)
            {
                Console.WriteLine("sozu daxil edin");
                list[i] = Console.ReadLine();
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("herfi daxil edin ");
                string herf = Console.ReadLine();

                int count = 0;

                for (int j = 0; j < list[i].Length; j++)
                {
                    if (list[i][j] == herf[0]) 
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Herf {herf} sozde {count} defe tapildi.");
            }
        }
    }
}
