using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Magazzino__più_istanze_
{
    internal class Storage
    {
        string[] Barcode = new string [50];
        string[] Description = new string[50];
        double[] Price = new double[50];
        int[] Units = new int[50];
        int[,] Sold = new int[50, 12];  //prodotti venduti
        int n;

        public Storage ()
        {
            n = 0;
        }
        public string GetBarcode(int i) { return Barcode[i]; }
        public string GetDescription(int i) { return Description[i]; }
        public double GetPrice(int i) { return Price[i]; }
        public int GetUnits(int i) { return Units[i]; }

        public void LoadData(string Barcode, string Descritpion, double Price, int Units)
        {
            this.Barcode[n] = Barcode;
            this.Description[n] = Descritpion;
            this.Price[n] = Price;
            this.Units[n] = Units;
            n++;
        }

        public double Discount (int i) 
        {
            Price[i] = Math.Round (Price[i] - ((Price[i] / 100) * 5), 2);
            return Price[i];
        }

        public int AddProducts(int i, int add) //metodo acquista
        {
            if (add > 0)
            {
                Units[i] = Units[i] + add;
                return Units[i];
            }
            else
                return -1;
        }

        public int SellProducts (int i, int SoldUnits, int month) //metodo vendita prodotti
        {
            if (SoldUnits > 0 && SoldUnits <= Units[i])
            {
                Sold[i,month]= SoldUnits; 
                Units[i] = Units[i] - SoldUnits;
                return Units[i];
            }
            else
                return -1;
        }

        public double StorageValue (int i) //valore di tutti i prodotti in magazzino
        {
            double value;
            return value = Units[i] * Price[i];
        }

        public int GetAllSellings() //visualizza tutte le vendite di tutti i prodotti anche in un anno
        {
            int[] sellings = new int[12];
            int max = 0, sum, pos = 0;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < 12; j++)
                {
                    sum = sum + Sold[i,j]; //somma + unità vendute in quel mese 
                    if (sum > max)
                    {
                        max = sum;
                        pos = i + 1;
                    }
                }
                Console.WriteLine("Il " + (i + 1) + "° prodotto è stato venduto " + sum + " volte");               
            }
            return pos;
        }

        public int Compare (string Barcode)
        {
            int found = -1;
            for (int i = 0; i < n; i++)
            {
                if (this.Barcode[i] == Barcode)
                    found = i;
            }
            return found;
        }
        public void ToString(int i)
        {
            Console.WriteLine("BARCODE: " + Barcode[i] + "\nDESCRIZIONE: " + Description[i] + "\nPREZZO: " + Price[i] + " euro" + "\nUNITÀ: " + Units[i]);
        }
    }
}