using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Terreno
{
    internal class Terrain
    {
        private string code; //codice
        private int extension; //estensione
        private int edPercentage; //percentuale edificabile
        private double annuity; //rendita MQ

        public string Code //inserimento codice
        {
            get { return code; }
            set { code = value; }
        }

        public int ExtensionSQ //inserimento metri quadri del terreno
        {
            get { return extension; }
            set { extension = value; }
        }

        public int Percentage  //inserimento percentuale edificabile del terreno
        {
            get { return edPercentage; }
            set { edPercentage = value; }
        }

        public double Annuity  //inserimento rendita del terreno
        {
            get { return annuity; }
            set { annuity = value; }
        }

        public double GetTotAnnuity (double totAnnuity) //GetRendita 
        {
            return totAnnuity; 
        }

        public int EdificablePercentage //stampa terreno edificabile in percentuale
        {
            get { return (edPercentage * extension) / 100; }
        }
        
        public string GetMaxExtension 
        {
            get { return code; }
        }
        public double GetAnnuityMedia (double a, double b, double c) //GetMediaRendita
        {
            return (a + b + c) / 3;
        }
        public void GetCode()
        {
            Console.WriteLine("Rendita del terreno: " + annuity + "\nTerreno edificabile: " + EdificablePercentage + "\nEstensione del terreno: " + ExtensionSQ + " MQ");
        }
    }
}