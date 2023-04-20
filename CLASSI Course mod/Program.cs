using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Course_mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIONE CORSO\n-------------------------------------");

            string coursename;
            string instructorname;
            string compare_course;
            int ele;
            int duration;
            bool num;
            int found = -1;
            int option;

            do
            {
                Console.WriteLine("Inserire il numero di corsi: ");
                num = int.TryParse(Console.ReadLine(), out ele);
                if (num == false)
                    Console.WriteLine("Errore di digitazione, riprova");
            } while (ele > 50 || ele <= 0 && !num);

            Course[] course = new Course[ele];

            for (int i = 0; i < ele; i++)
            {
                Console.WriteLine("Inserire il nome del " + (i + 1) + "° corso: ");
                coursename = Console.ReadLine();
                Console.WriteLine("Inserire la durata in ore del corso di " + coursename + ":");
                duration = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserire il nome dell'istruttore del corso di " + coursename + ":");
                instructorname = Console.ReadLine();

                course[i] = new Course(coursename, instructorname, duration);
            }

            do //INSERISCI CORSO DA RICERCARE
            {
                do
                {
                    Console.WriteLine("\nRICERCA\n-------------------------------------");
                    Console.WriteLine("Inserire il nome del corso da ricercare: ");
                    compare_course = Console.ReadLine();


                    for (int i = 0; i < ele; i++)
                    {
                        found = course[i].Compare(compare_course, i);
                        if (found != -1)
                        {
                            Console.WriteLine("\nCorso trovato!");
                            break;
                        }
                    }
                    if (found == -1)
                    {
                        Console.WriteLine("Corso non trovato, riprova");
                    }
                } while (found == -1);


                do //MENU
                {
                    Console.WriteLine("\nMENU\n1)Aggiungi un iscritto\n2)Rimuovi un iscritto\n3)Visualizza il numero di iscritti\n4)Visualizza l'elenco degli iscritti al corso\n5)Cambia il corso\n0)Esci");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("Il programma verrà chiuso");
                            break;

                        default:
                            Console.WriteLine("Scelta errata, riprova");
                            break;

                        case 1:
                            string add;
                            Console.WriteLine("\nInserire il nome dell'iscritto da aggiungere: ");
                            add = Console.ReadLine();
                            course[found].AddSubscriber(add);
                            break;

                        case 2:
                            string remove;
                            bool rm;
                            Console.WriteLine("\nInserire il nome dell'iscritto da rimuovere: ");
                            remove = Console.ReadLine();
                            rm = course[found].RemoveSubsciber(remove);
                            if (rm == true)
                                Console.WriteLine("\nRimozione riuscita");
                            else
                                Console.WriteLine("\nRimozione non riuscita");
                            break;

                        case 3:
                            Console.WriteLine("\nNumero di iscritti: " + course[found].NumberOfSubscribers());
                            break;

                        case 4:
                            for (int i = 0; i < course[found].NumberOfSubscribers(); i++)
                            {
                                Console.WriteLine(course[found].GetSubscribers(i));
                            }
                            break;
                        case 5:
                            break;
                    }
                } while (option != 0 && option != 5);
            } while (option != 0);
            Console.ReadKey();
        }
    }
}
