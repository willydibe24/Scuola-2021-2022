using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Biglietteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Code;
            string Name;
            int TicketNumber;
            double Price;
            double Discount = 0; //lo sconto di default è del 5%
            int PeopleNumber;
            int option;

            Console.WriteLine("Inserire il codice della macchinetta: ");
            Code = Console.ReadLine();
            Console.WriteLine("Inserire il nome della macchinetta: ");
            Name = Console.ReadLine();
            Console.WriteLine("Inserire il numero di biglietti presenti nella macchinetta: ");
            TicketNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il prezzo del biglietto: ");
            Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero di persone: ");
            PeopleNumber = int.Parse(Console.ReadLine());
            TicketOffice prova = new TicketOffice();

            prova.Code = "ciao";

            CumulativeTO ticketoffice = new CumulativeTO (Code, Name, TicketNumber, Price, Discount, PeopleNumber);

            do
            {
                Console.WriteLine("\nMENU\n1)Ricarica la macchinetta\n2)Vendi biglietti\n3)Manutenzione macchinetta\n4)Applica sconto\n0)Esci");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    default:
                        Console.WriteLine("\nErrore di digitazione, riprova");
                        break;

                    case 0:
                        Console.WriteLine("\nIl programma verrà chiuso");
                        break;

                    case 1:
                        int refill;
                        Console.WriteLine("\nCon quanti biglietti vuoi riempire la macchinetta?");
                        refill = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nLa macchinetta ora ha " + ticketoffice.Refill(refill) + " biglietti"); 
                        break;

                    case 2:
                        int sell;
                        double sold;
                        Console.WriteLine("\nQuanti biglietti vuoi vendere?");
                        sell = int.Parse(Console.ReadLine());
                        sold = ticketoffice.Sell(sell);
                        if (sold == 0)
                            Console.WriteLine("\nNumero di biglietti insufficiente.");
                        else
                            Console.WriteLine("\nBiglietti presenti nella macchinetta: " + ticketoffice.GetTicketNumber() + "\nGuadagno ricavato: " + sold + " euro");
                        break;

                    case 3:
                        Console.WriteLine(ticketoffice.Repair());
                        break;

                    case 4:
                        Console.WriteLine("\nPrezzo di un biglietto scontato: " + ticketoffice.AddDiscount());
                        break;
                }
            } while (option != 0);
        }
    }
}
