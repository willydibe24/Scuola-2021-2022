using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Auto_Persona
{
    internal class Car
    {
        private string Plate; //targa
        private string Displacement; //cilindrata 
        private string Brand; //marca
        private Person Owner; //proprietario
        public Car (string Plate, string Displacement, string Brand, Person Owner)
        {
            this.Plate = Plate;
            this.Displacement = Displacement;
            this.Brand = Brand;
            this.Owner = Owner;
        }

        public string GetPlate() { return Plate; }
        public string GetDisplacement() { return Displacement; }
        public string GetBrand() { return Brand; }
        public string  GetOwner() { return Owner.GetOwner(); } 
    }
}
