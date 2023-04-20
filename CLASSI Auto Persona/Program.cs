using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Auto_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plate, displacement, brand;
            string surname, name, city, birthdate, fc;

            Console.WriteLine("Inserire la targa della macchina: ");
            plate = Console.ReadLine();
            Console.WriteLine("Inserire la cilindrata della macchina: ");
            displacement = Console.ReadLine();
            Console.WriteLine("Inserire la marca della macchina: ");
            brand = Console.ReadLine();
            Console.WriteLine("Inserire il cognome del proprietario della macchina: ");
            surname = Console.ReadLine();
            Console.WriteLine("Inserire il nome del proprietario dela macchina: ");
            name = Console.ReadLine();
            Console.WriteLine("Inserire la città di provenienza di " + name + " " + surname);
            city = Console.ReadLine();
            Console.WriteLine("Inserire la data di nascita di " + name + " " + surname);
            birthdate = Console.ReadLine();
            Console.WriteLine("Inserire il codice fiscale di " + name + " " + surname);
            fc = Console.ReadLine();

            Person person = new Person(surname, name, city, birthdate, fc);
            Car car = new Car(plate, displacement, brand, person);        
            
            //stampa
            Console.WriteLine("\nINFORMAZIONI AUTOMOBILE:");
            Console.WriteLine("TARGA: " +car.GetPlate());
            Console.WriteLine("CILINDRATA: " + car.GetDisplacement());
            Console.WriteLine("MARCA: " + car.GetBrand());
            Console.WriteLine(car.GetOwner());

            Console.ReadKey();
        }
    }
}
