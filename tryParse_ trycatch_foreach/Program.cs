using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParse__trycatch_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ris;
            int n, p = 0;
            int[] vet = new int[3] { 1, 2, 3 };
            Console.WriteLine("METODO TRYPARSE");
            do
            {
                Console.WriteLine("inserire un numero: ");
                ris = int.TryParse(Console.ReadLine(), out n);
                if (ris == false)
                    Console.WriteLine("Errore, riprova");
            } while (!ris);

            Console.WriteLine("RISULTATO: " + n + "\n\n");

            //alternativa
            Console.WriteLine("METODO TRY-CATCH");
            do
            {
                try
                {
                    Console.WriteLine("Inserire partite perse: ");
                    p = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Errore");
                }
            } while (p == 0);

            Console.WriteLine("RISULTATO: " + p + "\n\n");
            p = 0;

            Console.WriteLine("METODO TRY-CATCH (Format exception)");
            do
            {
                try
                {
                    Console.WriteLine("Inserire partite perse: ");
                    p = int.Parse(Console.ReadLine());
                }
                catch (FormatException) //darà il messaggio d'errore solo nel caso in cui il formato in input sia diverso da int 
                {
                    Console.WriteLine("Errore, Format exception");
                }
                catch
                {
                    Console.WriteLine("Errore inaspettato");
                }
            } while (p == 0);

            Console.WriteLine("RISULTATO: " + p + "\n\n");
            p = 0;

            Console.WriteLine("METODO TRY-CATCH (OverflowException)");
            do
            {
                try
                {
                    Console.WriteLine("Inserire partite perse: ");
                    p = int.Parse(Console.ReadLine());
                }
                catch (OverflowException) //darà il messaggio d'errore solo nel caso in cui l'input dato ecceda il valore massimo del tipo int 
                {
                    Console.WriteLine("Errore, OverflowException");
                }
                catch
                {
                    Console.WriteLine("Errore inaspettato");
                }
            } while (p == 0);

            Console.WriteLine("RISULTATO: " + p + "\n\n");
            p = 0;

            Console.WriteLine("METODO TRY-CATCH (SystemExceptiom)");
            do
            {
                try
                {
                    Console.WriteLine("Inserire partite perse: ");
                    p = int.Parse(Console.ReadLine());
                }
                catch (SystemException e) //darà il messaggio d'errore solo nel caso in cui ci sia una SystemException, visualizzando il tipo d'errore assegnato all'oggetto "e"
                {
                    Console.WriteLine("Errore: " + e.Message);
                }
            } while (p == 0);

            Console.WriteLine("RISULTATO: " + p + "\n\n");


            Console.WriteLine("CICLO FOREACH");
            foreach (int i in vet)
            {
                Console.WriteLine("numero: " + i);
            }
        }
    }
}

