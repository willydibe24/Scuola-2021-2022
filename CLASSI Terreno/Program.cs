using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option; //scelta  

            Terrain a = new Terrain();
            Terrain b = new Terrain();
            Terrain c = new Terrain();

            Console.WriteLine("Inserire il codice del 1° terreno: ");
            a.Code = Console.ReadLine();
            Console.WriteLine("Inserire l'estensione in MQ del terreno: ");
            a.ExtensionSQ = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la percentuale del terreno edificabile: ");
            a.Percentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la rendita del terreno: ");
            a.Annuity = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentuale edificabile: " +a.EdificablePercentage + " MQ");

            Console.WriteLine("Inserire il codice del 2° terreno: ");
            b.Code = Console.ReadLine();
            Console.WriteLine("Inserire l'estensione in MQ del terreno: ");
            b.ExtensionSQ = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la percentuale del terreno edificabile: ");
            b.Percentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la rendita del terreno: ");
            b.Annuity = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentuale edificabile: " + b.EdificablePercentage + " MQ");

            Console.WriteLine("Inserire il codice del 3° terreno: ");
            c.Code = Console.ReadLine();
            Console.WriteLine("Inserire l'estensione in MQ del terreno: ");
            c.ExtensionSQ = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la percentuale del terreno edificabile: ");
            c.Percentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la rendita del terreno: ");
            c.Annuity = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentuale edificabile: " + c.EdificablePercentage +" MQ");

            do
            {
                Console.WriteLine("MENU\n1)Stampa il terreno che ha il massimo di metri quadri edificabili\n2)Stampa della rendita media dei terreni\n3)Stampa i dati di un terreno dato il suo codice\n0)Esci");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        
                        if (a.EdificablePercentage > b.EdificablePercentage && a.EdificablePercentage > c.EdificablePercentage)
                            Console.WriteLine("codice del terreno: " + a.GetMaxExtension);
                        else if (b.EdificablePercentage > a.EdificablePercentage && b.EdificablePercentage > c.EdificablePercentage)
                            Console.WriteLine("codice del terreno: " + b.GetMaxExtension);
                        else if (c.EdificablePercentage > a.EdificablePercentage && c.EdificablePercentage > b.EdificablePercentage)
                            Console.WriteLine("codice del terreno: " + c.GetMaxExtension); 
                        else
                            Console.WriteLine("Nessun terreno prevale sugli altri per l'estensione");
                        break;

                    case 2:
                        double ta = a.Annuity, tb = b.Annuity, tc = c.Annuity;
                        Console.WriteLine("Guadagno medio dei 3 terreni: " + a.GetAnnuityMedia(ta, tb, tc));
                        break;

                    case 3:
                        Console.WriteLine("Inserire il codice da ricercare: ");
                        string code = Console.ReadLine();
                        if (code == a.Code)
                            a.GetCode();
                        else if (code == b.Code)
                            b.GetCode();
                        else if (code == c.Code)
                            c.GetCode();
                        else
                            Console.WriteLine("Codice non trovato");
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
