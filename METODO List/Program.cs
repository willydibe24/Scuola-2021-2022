
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODO_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pointer, cont;
            List<int> b = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                b.Add(i * 4);
            }

            int option;
            do
            {
                Console.WriteLine("\nMENU\n1)Modifica un elemento\n2)Aggiungi un elemento\n3)Rimuovi un elemento\n4)Visualizza la lista");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Il programma verrà chiuso");
                        break;

                    default:
                        Console.WriteLine("Inserimento errato, riprova");
                        break;

                    case 1:
                        do
                        {
                            cont = 1;
                            Console.WriteLine("\nLISTA: ");
                            foreach (int i in b)
                            {
                                Console.WriteLine(cont + "° numero: " + i);
                                cont++;
                            }
                            Console.WriteLine("\nInserisci quale elemento vuoi modificare: ");
                            pointer = int.Parse(Console.ReadLine());
                            pointer -= 1;
                        } while (pointer < 0 || pointer > b.Count);

                        Console.WriteLine("\nNumero richiamato: " + b[pointer]);
                        do
                        {
                            Console.WriteLine("\nChe valore vuoi assegnare? ");
                            b[pointer] = int.Parse(Console.ReadLine());
                        } while (b[pointer] <= 0);

                        break;

                    case 2:
                        int value;
                        Console.WriteLine("\nIn che posizione vuoi inserire l'elemento?");
                        pointer = int.Parse(Console.ReadLine());
                        pointer -= 1;
                        Console.WriteLine("\nChe valore vuoi inserire?");
                        value = int.Parse(Console.ReadLine());
                        b.Insert(pointer, value);

                        break;

                    case 3:
                        cont = 1;
                        pointer = 0;
                        Console.WriteLine("\nLISTA: ");
                        foreach (int i in b)
                        {
                            Console.WriteLine(cont + "° numero: " + i);
                            cont++;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Inserire la posizione dell'elemento da rimuovere: ");
                        pointer = int.Parse(Console.ReadLine());
                        b.RemoveAt(pointer - 1);
                        Console.WriteLine("\nElemento rimosso");

                        break;

                    case 4:
                        cont = 1;
                        Console.WriteLine("\nElementi della lista: " + b.Count);
                        Console.WriteLine("\nLISTA: ");
                        foreach (int i in b)
                        {
                            Console.WriteLine(cont + "° numero: " + i);
                            cont++;
                        }
                        Console.WriteLine();
                        break;    
                }
            } while (option != 0);

            Console.ReadKey();
        }
    }
}
