using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_SIM_Verifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABILI CLASSE SIM
            string phoneNumber;
            string provider;
            double credit;

            // ALTRE VARIABILI
            int option;


            Console.WriteLine("GESTIONE SIM\n-----------------");
            Console.WriteLine("\nInserire il numero di telefono: ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("\nInserire l'operatore telefonico: ");
            provider = Console.ReadLine();
            Console.WriteLine("\nInserire il credito presente: ");
            credit = double.Parse(Console.ReadLine());

            Sim sim = new Sim(phoneNumber, provider, credit);

            do
            {
                Console.WriteLine("\nMENU"+
                    "\n1)Effettua una telefonata" +
                    "\n2)Visualizza l'importo totale delle telefonate fatte" +
                    "\n3)Visualizza il tempo medio di chiamata" +
                    "\n4)Informazioni sim" +
                    "\n5)Ricarica la sim" +
                    "\n0)Esci");


                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nInserire la durata della chiamata (in secondi): ");
                        sim.timeSpent = double.Parse(Console.ReadLine());
                        Console.WriteLine(sim.AddPhoneCall());
                        break;

                    case 0:
                        Console.WriteLine("\nIl programma verrà chiuso");
                        break;

                    default:
                        Console.WriteLine("\nErrore di digitazione, riprova");
                        break;

                }
            } while (option != 0);

        }
    }
}
