using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Auto_Persona
{
    internal class Person
    {
        private string Surname; //cognome
        private string Name; //nome 
        private string City; //città di provenienza
        private string BirthDate; //data di nascita 
        private string FC; //codice fiscale 

        public Person (string Surname, string Name, string City, string BirthDate, string FC)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.City = City;
            this.BirthDate = BirthDate;
            this.FC = FC;
        }

        public string GetOwner() { return "COGNOME: " + Surname + "\nNOME: " + Name + "\nCITTA': " + City + "\nDATA DI NASCITA: " + BirthDate + "\nCODICE FISCALE: " + FC; }
    }
}
