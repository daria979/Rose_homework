using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTK_2
{
    class Program
    {
        /// <summary>
        /// Problema 1
        /// </summary>
        /// <param name="args"></param>

        //Dacă elevii unei clase se așează câte n într-o bancă, 
        //vor rămâne e elevi în picioare, iar dacă se așează 
        //câte m într-o bancă, vor rămâne b bănci neocupate.

        //Cerință
        //Care este numărul de elevi, respectiv de bănci, din clasa respectivă?

        //Date de intrare
        //Se vor citi pe rând numerele naturale n, m, e și b

        //Date de ieșire
        //Se va afișa pe primul rând numărul de elevi, iar pe următorul 
        //rând numărul de banci din clasa respectivă.

        //Restricții și precizări
        //Numerele date, precum și rezultatele calculate nu vor 
        //epăși 108 (este vorba de o școală intergalactică);
        //Este posibil ca acea clasă să fie goală…

        static void elevi()
        {
            int n, m, e, b;
            int elevi, banci;

            string line;

            line = Console.ReadLine();
            

            char[] seps = { ' ', '.', ',', '?' };
            string[] date = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            n = int.Parse(date[0]);
            m = int.Parse(date[1]);
            e = int.Parse(date[2]);
            b = int.Parse(date[3]);
            //se deduce faptul ca n<=m
            // se efectueaza un sistem:
            // elevi / n = banci rest e => elevi = n*banci + e
            // elevi / m = banci - b       elevi = m*(banci - b)

            // se egaleaza => 
            banci = (e + m * b) / (m - n);
            elevi = n * banci + e;

            Console.WriteLine($"Numarul de banci: {banci}");
            Console.WriteLine($"Numarul de elevi: {elevi}");

        }


        /// <summary>
        /// Problema 2
        /// </summary>
        /// <param name="args"></param>

        //Se dau 2 numere naturale h m, reprezentând un ora curentă exprimată în ore
        //şi minute.Să se determine care va fi ora peste x minute.

        //Date de intrare
        //Programul citește de la tastatură numerele h1 m1 x.

        //Date de ieşire
        //Programul afișează pe ecran numerele h2 m2, separate printr-un spaţiu, 
        //cu semnificaţia din enunţ.

        //Restricţii şi precizări
        //0 ≤ h1, h2 ≤ 23
        //0 ≤ m1, m2 ≤ 59
        //0 ≤ x ≤ 10000

        static void time()
        {
            int h1, h2, m1, m2, x;
            string line;

            line = Console.ReadLine();

            char[] seps = { ' ', '.', ',', '?' };
            string[] time = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            h1 = int.Parse(time[0]);
            m1 = int.Parse(time[1]);
            x = int.Parse(time[2]);

            
            Console.WriteLine($"Ora curenta: ora {h1} si {m1} minute");

            m2 = (m1 + x) % 60; 
            h2 = h1 + x / 60;
            

            Console.WriteLine($"Ora noua peste {x} minute: ora {h2} si {m2} minute");


        }
        static void Main(string[] args)
        {
            //elevi();
            time();
        }
    }
}
