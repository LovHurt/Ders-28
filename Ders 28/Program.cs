using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] students = new string[3];
            students[0] = "Veli";
            students[1] = "Mehmet";
            students[2] = "Ahmet";

            string[] students2 = new[] { "Engin", "Derin", "Salih" };

            string[] students3 = { "X", "Y", "Z" };

            string[] students4 = new string[3]{ "A", "B", "C" };


            foreach (var student in students) { 
            
                Console.WriteLine(student);
                
            }
            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir" },
                {"Ankara", "Konya", "Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"İzmir", "Muğla", "Aydın" },
                {"Rize", "Trabzon", "Manisa" }
            };

            for (int i = 0; i <=regions.GetUpperBound(0) i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*************");
            }

            Console.ReadLine();



        }

      
    }
}
