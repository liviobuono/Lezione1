using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 444444;

            Console.WriteLine($"il valore del numero è: {numero}");

            short soluzione = (short)numero;

            Console.WriteLine($"il valore della soluzione è: {soluzione}");

            Console.ReadLine();
        }
    }
}
