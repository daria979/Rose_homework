using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMK_1
{
    class Program
    {
        /// <summary>
        /// Pe planeta Marte anul marțian durează x zile marțiene, 
        /// iar o zi marțiană durează y ore. În fiecare oră, marțianului Iggle îi crește o 
        /// antenă. După cât timp va avea Iggle n antene?
        /// 
        /// Programul citește de la tastatură numerele naturale x y n.
        /// 
        /// Programul va afișa pe ecran trei numere naturale: a, z, h, pe rânduri diferite, 
        /// reprezentând numărul de ani, zile și ore după care Iggle va avea n antene.
        /// 
        ///Intrare: 5 3 100
        ///Ieșire: 6 3 1 (una sub alta)
        ///
        ///Explicație
        ///Anul marțian are 5 zile, iar ziua marțiană are 3 ore.
        ///Astfel, un an marțian va avea 5*3 = 15 ore.
        ///Atunci 100 de zile marțiene înseamnă 6 ani și încă 10 ore.
        ///Cele 10 ore înseamnă 3 zile și 1 oră.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int x, y, n;

            string line;

            line = Console.ReadLine();

            char[] seps = { ' ', '.', ',', '?' };
            string[] numere = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            n = int.Parse(numere[2]);

            int a = 0;
            int z = 0;
            int h = 0;

            a = n / (x * y);
            h = n % (x * y);
            
            if(h>y)
            {
                z = h / y;
                h = h % y;
            }

            Console.Write(a+" ani");
            Console.WriteLine();
            Console.Write(z+" zile");
            Console.WriteLine();
            Console.Write(h+" ore");
            Console.WriteLine();
            //Console.ReadKey();

        }
    }
}
