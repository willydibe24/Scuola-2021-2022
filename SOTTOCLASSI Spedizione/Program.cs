using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Spedizione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            string adress;
            string city;
            string nation = null;
            double exchange = 1;
            int option;

            Console.WriteLine("GESTIONE SPEDIZIONI\n------------------------------------");
            do
            {
                Console.WriteLine("\nInserire il peso del pacco: ");
                weight = double.Parse(Console.ReadLine());
            } while (weight < 0);
            
            do
            {     
                Console.WriteLine("\nInserire la valuta del proprio paese (dollari/euro/yen): ");
                nation = Console.ReadLine();
            } while (nation != "yen" && nation != "YEN" && nation != "Yen" && nation != "euro" && nation != "EURO" && nation != "Euro" && nation != "dollari" && nation != "DOLLARI" && nation != "Dollari");
            Console.WriteLine("\nInserire la città di destinazione: ");
            city = Console.ReadLine();
            Console.WriteLine("\nInserire l'indirizzo: ");
            adress = Console.ReadLine();

            Delivery delivery = new Delivery(weight, adress, city);
            Abroad abroad = new Abroad(weight, adress, city, nation, exchange);
            abroad.SetExchange(); //imposta il cambio di valuta per la moneta selezionata

            do
            {
                Console.WriteLine("\nMENU" +
                    "\n1)Visualizza il costo della spedizione" +
                    "\n2)Visualizza tutte le caratteristiche della spedizione" +
                    "\n3)Aggiorna lo stato di consegna del pacco" +
                    "\n4)Modifica il valore del cambio nel paese" +
                    "\n0)Esci");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    default:
                        Console.WriteLine("\nScelta errata, riprova");
                        break;

                    case 0:
                        Console.WriteLine("\nIl programma verrà chiuso");
                        break;

                    case 1:
                        Console.WriteLine("\nIl costo della spedizione ammonta a " + abroad.Cost() + " " + nation);
                        break;

                    case 2:
                        Console.WriteLine(abroad.ViewAll());
                        break;

                    case 3:
                        if (delivery.HasBeenDelivered() == true)
                            Console.WriteLine("\nConsegna effettuata");
                        else
                            Console.WriteLine("\nIl pacco è già stato consegnato");
                        break;

                    case 4:
                        int ex;
                        Console.WriteLine("\nInserire il valore del cambio: ");
                        exchange = double.Parse(Console.ReadLine());
                        ex = abroad.UpdateExchange(exchange);

                        if (ex == 1)
                            Console.WriteLine("\nIl valore inserito è maggiore del valore del cambio del paese");
                        else if (ex == -1)
                            Console.WriteLine("\nIl valore inserito è minore del valore del cambio del paese");
                        else
                            Console.WriteLine("\nI due valori coincidono tra di loro");
                                
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}
