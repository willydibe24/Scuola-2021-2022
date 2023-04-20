using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Magazzino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIONE PRODOTTI\n--------------------------------");

            Random r = new Random();
            int n, option, found = -1;
            string bcode, desc, compare_bcode; //barcode, description
            double prc; //price
            int uni; //units 
            string[] months = new string[12] { "gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };

            Storage storage = new Storage();  

            do
            {
                Console.WriteLine("Inserire il numero di prodotti: ");
                n = int.Parse(Console.ReadLine());
            } while (n > 50 || n <= 0);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserire il barcode del " + (i + 1) + "° prodotto: ");
                bcode = Console.ReadLine();
                Console.WriteLine("Inserire la descrizione del " + (i + 1) + "° prodotto: ");
                desc = Console.ReadLine();
                Console.WriteLine("Inserire il prezzo del " + (i + 1) + "° prodotto: ");
                prc = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserire le unità del " + (i + 1) + "° prodotto: ");
                uni = int.Parse(Console.ReadLine());

                storage.LoadData(bcode, desc, prc, uni);
            }

            do
            {
                int month;

                Console.WriteLine("--------------------------------");
                month = r.Next(0, 12);
                Console.WriteLine("\nMese: " +months[month]);

                do
                {
                    Console.WriteLine("\nRICERCA\n--------------------------------");
                    Console.WriteLine("Inserire il barcode del prodotto da ricercare: ");
                    compare_bcode = Console.ReadLine();

                    found = storage.Compare(compare_bcode);
                    if (found > -1)
                        Console.WriteLine("\nProdotto trovato!");
                    else
                        Console.WriteLine("\nProdotto non trovato! Riprova");

                } while (found == -1);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("MENU\n1)Applica uno sconto del 5%\n2)Vendi il prodotto\n3)Aggiungi unità del prodotto\n4)Calcola il valore complessivo delle unità presenti in magazzino\n5)Visualizza le vendite in 1 anno e visualizza il prodotto pìù venduto\n6)Caratteristiche del prodotto\n0)Esci");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    default:
                        Console.WriteLine("Scelta errata, riprova");
                        break;

                    case 0:
                        Console.WriteLine("Il programma verrà chiuso");
                        break;

                    case 1:
                        double discount = storage.Discount(found);
                        Console.WriteLine("\nSconto applicato. Ora il prezzo ammonta a " + storage.GetPrice(found) + " euro");
                        break;

                    case 2:
                        Console.WriteLine("Quante unità vuoi vendere? ");
                        int soldunits = int.Parse(Console.ReadLine());
                        int sold = storage.SellProducts(found, soldunits, month);
                        if (sold > -1)
                            Console.WriteLine("\nVendita effettuata! Ora le unità presenti sono " + storage.GetUnits(found));
                        else
                            Console.WriteLine("\nVendita non effettuata. Unità insufficienti!");         
                        break;

                    case 3:
                        int added, add;
                        do
                        {
                            Console.WriteLine("\nInserire il numero di prodotti da aggiungere: ");
                            added = int.Parse(Console.ReadLine());
                        } while (added <= 0);
                        
                        add = storage.AddProducts(found, added);

                        if (add > -1)
                            Console.WriteLine("\nAggiunta effettuata! Ora le unità presenti sono " + storage.GetUnits(found));
                        else
                            Console.WriteLine("\nAggiunta non effettuata!");
                        break;

                    case 4:
                        double value = storage.StorageValue(found);
                        Console.WriteLine("\nValore complessivo delle unità in magazzino: " + value + " euro");
                        break;

                    case 5:
                        int max = storage.GetAllSellings();
                        if (max != 0)
                            Console.WriteLine("Il " + max + "° prodotto è il più venduto");
                        else
                            Console.WriteLine("Nessun prodottto è stato venduto");
                        break;

                    case 6:
                        storage.ToString(found);
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}