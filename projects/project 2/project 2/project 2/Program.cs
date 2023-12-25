using System;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("listin uzunlugu ");
            string listLengthStr = Console.ReadLine();
            int listLength = Convert.ToInt32(listLengthStr);

            int[] list = new int[listLength];

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("ededi daxil edin ");
                string ededstr = Console.ReadLine();
                int eded = Convert.ToInt32(ededstr);
                list[i] = eded;
            }

            Console.WriteLine("n ededini daxil edin");
            string nstr = Console.ReadLine();
            int n = Convert.ToInt32(nstr);

            bool found = false;

            for (int i = 0; i < list.Length; i++)
            {
                if (n == list[i])
                {
                    Console.WriteLine("n ededinin indeksi " + i + " - ci indexdir");
                    found = true;
                    break;  // Break out of the loop once the number is found
                }
            }

            if (!found)
            {
                Console.WriteLine("Daxil etdiyiniz eded indeksde yerleshmir");
            }
        }
    }
}
