using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfPages
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "args.txt");

            if (args.Length > 0)
            {
                try
                {
                    File.WriteAllLines(path, args, Encoding.UTF8);

                    Console.WriteLine("Argomenti ricevuti:");
                    foreach (string arg in args)
                    {
                        Console.WriteLine(" - " + arg);
                    }

                    Console.WriteLine("\nArgomenti salvati in: " + path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Errore durante il salvataggio: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Nessun argomento passato.");
            }

            Console.WriteLine("\nPremi un tasto per uscire... Bravo");
            Console.ReadKey();
        }
    }
}
