using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Magazzino__più_istanze_
{
    internal class Storage
    {
        string Barcode;
        string Description;
        double Price;
        int Units;
        int[] Sold = new int[12];  //prodotti venduti

        public Storage(string Barcode, string Description, double Price, int Units)
        {
            this.Barcode = Barcode;
            this.Description = Description;
            this.Price = Price;
            this.Units = Units;
        }

        public string GetBarcode() { return Barcode; }
        public string GetDescription() { return Description; }
        public double GetPrice() { return Price; }
        public int GetUnits() { return Units;}
        public int GetSold(int i) { return Sold[i]; }

        public double Discount()
        {
            Price = Math.Round(Price - ((Price / 100) * 5), 2);
            return Price;
        }

        public int AddProducts(int add) //metodo acquista
        {
            if (add > 0)
            {
                Units = Units + add;
                return Units;
            }
            else
                return -1;
        }

        public int SellProducts(int SoldUnits, int month) //metodo vendita prodotti
        {
            if (SoldUnits > 0 && SoldUnits <= Units)
            {
                Sold[month] = SoldUnits;
                Units = Units - SoldUnits;
                return Units;
            }
            else
                return -1;
        }

        public double StorageValue() //valore di tutti i prodotti in magazzino
        {
            double value;
            return value = Units * Price;
        }

        public int GetAllSellings() //visualizza tutte le vendite di tutti i prodotti anche in un anno
        {
            int[] sellings = new int[12];
            int sum = 0;
            for (int i = 0; i < 12; i++)
                sum += Sold[i]; //somma + unità vendute in quel mese 
            return sum;
        }

        public int Compare(string Barcode, int i)
        {
            int found = -1;
            if (this.Barcode == Barcode)
            {
                found = i;
            }
            return found;
        }
        public string ToString()
        {
            return ("BARCODE: " + Barcode + "\nDESCRIZIONE: " + Description + "\nPREZZO: " + Price + " euro" + "\nUNITÀ: " + Units);
        }
    }
}
