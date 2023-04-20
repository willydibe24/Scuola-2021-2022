using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Studente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v, last, nV, option;
            double media;

            Studente student = new Studente();
            Console.WriteLine("Inserire il nome dello studente: ");
            student.name = Console.ReadLine();
            do
            {
                Console.WriteLine("Inserire il numero di voti di " + student.name + ": ");
                nV = int.Parse(Console.ReadLine());
            } while (nV <= 0);
            
            for (int i = 0; i < nV; i++)
            {
                Console.WriteLine("Inserire il " +(i+1)+ "° voto: ");
                student.Vote = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("\nMENU\n1)Visualizza la media\n2)Visualizza l'ultimo voto\n3)Aggiungi un voto\n0)Esci");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        media = student.Media(nV);
                        Console.WriteLine("Media dei voti: " + media);
                        break;

                    case 2:
                        last = student.GetLast;
                        Console.WriteLine("Ultimo voto: " + student.GetLast);
                        break;

                    case 3:
                        Console.WriteLine("Aggiungi un voto: ");
                        student.Vote = int.Parse(Console.ReadLine());
                        nV++;
                        break;

                    case 0:
                        Console.WriteLine("Il programma verrà chiuso");
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}