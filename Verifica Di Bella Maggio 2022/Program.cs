using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Di_Bella_Maggio_2022
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // variabili superclasse
            string model = "Mercedes";
            int year = 2010;
            int seats = 50;
            double ticketCost = 2.50;
            int km;
            int emitted;

            // variabili sottoclasse
            int cities = 4;

            // altre variabili
            int option;
            bool o;
            
            BusAgency busAgency = new BusAgency(model, year, seats, ticketCost);
            Suburban suburban = new Suburban(model, year, seats, ticketCost, cities, false);



            Console.WriteLine("\nATTENZIONE: I KM E I BIGLIETTI VENDUTI SONO INIZIALIZZATI A 0");
            do
            {
                do
                {
                    Console.WriteLine("\nMENU" +
                    "\n1)Inserisci i km e i biglietti venduti e visualizzali" +
                    "\n2)Incasso complessivo" +
                    "\n3)Incasso annuale" +
                    "\n4)Varia costo del biglietto (inserisci un valore in percentuale)" +
                    "\n5)Visualizza tutto" +
                    "\n6)Incasso complessivo (sottoclasse)" +
                    "\n7)Imposta estate su true o su false (sottoclasse)" +
                    "\n8)Visualizza tutto (sottoclasse)" +
                    "\n0)Esci");

                    o = int.TryParse(Console.ReadLine(), out option);
                    if (o == false)
                        Console.WriteLine("\nScelta errata, riprova");

                } while (o == false);

                switch (option)
                {
                    default:
                        Console.WriteLine("\nScelta errata, riprova");
                        break;

                    case 0:
                        Console.WriteLine("\nIl programma verrà chiuso");
                        break;

                    case 1:
                        Console.WriteLine("\nInserire i km percorsi: ");
                        km = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nInserire i biglietti emessi: ");
                        emitted = int.Parse(Console.ReadLine());
                        Console.WriteLine(busAgency.EndOfTheDay(km, emitted));
                        suburban.EndOfTheDay(km, emitted); // assegna il valore delle variabili alle proprietà della sottoclasse
                        break;

                    case 2:
                        Console.WriteLine("\n" + busAgency.TotalEarning() + " euro");
                        break;

                    case 3:
                        Console.WriteLine("\nInserire l'anno corrente: (l'autobus è stato acquistato nel 2010): ");
                        int currentyear = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n" + busAgency.AnnualEarning(currentyear) + " euro");
                        break;

                    case 4:
                        Console.WriteLine("\nInserire il valore in percentuale: ");
                        double percentage = double.Parse(Console.ReadLine());
                        Console.WriteLine(busAgency.ChangeCost(percentage)); 

                        break;

                    case 5:
                        Console.WriteLine(busAgency.ViewAll());
                        break;

                    case 6:
                        Console.WriteLine(suburban.TotalEarning() + " euro");
                        break;

                    case 7:
                        Console.WriteLine("\nEstate: " + suburban.SetSummer());
                        break;

                    case 8:
                        Console.WriteLine(suburban.ViewAll());
                        break;
                }
            } while (option != 0);
            Console.ReadKey();

        }
    }
}
