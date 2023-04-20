using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Magazzino__più_istanze_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIONE PRODOTTI\n--------------------------------");

            Random r = new Random();
            int n; //numero prodotti
            int uni; //units 
            int option; //opzione nel menù
            int found = -1; //utilizzato per ricercare il barcode
            bool num; //utilizzato nel tryparse
            double prc; //price
            string bcode, desc, compare_bcode; //barcode, description
            string[] months = new string[12] { "gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };


            do
            {
                Console.WriteLine("Inserire il numero di prodotti: ");
                num = int.TryParse(Console.ReadLine(), out n);

                if (num == false)
                    Console.WriteLine("Errore di digitazione, riprova");
            } while (n > 50 || n <= 0 && !num);

            Storage[] product = new Storage[n];

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

                product[i] = new Storage(bcode, desc, prc, uni);
            }

            do
            {
                int month;

                Console.WriteLine("--------------------------------");
                month = r.Next(0, 12);
                Console.WriteLine("\nMese: " + months[month]);

                do
                {
                    Console.WriteLine("\nRICERCA\n--------------------------------");
                    Console.WriteLine("Inserire il barcode del prodotto da ricercare: ");
                    compare_bcode = Console.ReadLine();

                    for (int i = 0; i < n; i++)
                    {
                        found = product[i].Compare(compare_bcode, i);

                        if (found > -1)
                        {
                            Console.WriteLine("\nProdotto trovato!");
                            break;
                        }
                    }
                    if (found == -1)
                        Console.WriteLine("Prodotto non trovato, riprova");
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
                        double discount = product[found].Discount();
                        Console.WriteLine("\nSconto applicato. Ora il prezzo ammonta a " + product[found].GetPrice() + " euro");
                        break;

                    case 2:
                        Console.WriteLine("Quante unità vuoi vendere? ");
                        int soldunits = int.Parse(Console.ReadLine());
                        int sold = product[found].SellProducts(soldunits, month);
                        if (sold > -1)
                            Console.WriteLine("\nVendita effettuata! Ora le unità presenti sono " + product[found].GetUnits());
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

                        add = product[found].AddProducts(added);

                        if (add > -1)
                            Console.WriteLine("\nAggiunta effettuata! Ora le unità presenti sono " + product[found].GetUnits());
                        else
                            Console.WriteLine("\nAggiunta non effettuata!");
                        break;

                    case 4:
                        double value = product[found].StorageValue();
                        Console.WriteLine("\nValore complessivo delle unità in magazzino: " + value + " euro");
                        break;

                    case 5:
                        int sum, max = 0;
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 12; j++)
                            {
                                Console.WriteLine("Vemdite del " + (i + 1) + "° prodotto nel mese di " + months[j] + ": " + product[i].GetSold(j));
                            }
                            sum = product[i].GetAllSellings();
                            if (sum > max)
                                max = i + 1;
                        }

                        if (max != 0)
                            Console.WriteLine("\nIl " + max + "° prodotto è il più venduto");
                        else
                            Console.WriteLine("\nNessun prodotto è stato venduto o è prevalso sugli altri");
                        break;

                    case 6:
                        Console.WriteLine(product[found].ToString());
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}