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

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //se deduce faptul ca n<=m
            // se efectueaza un sistem:
            // elevi / n = banci rest e => elevi = n*banci + e
            // elevi / m = banci - b       elevi = m*(banci - b)

            // se egaleaza => 
            banci = (e + m * b) / (m - n);
            elevi = n * banci + e;

        }
        static void Main(string[] args)
        {
            elevi();
        }
    }
}
