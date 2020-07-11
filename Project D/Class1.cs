using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_D
{
    class Car
    {
        public int ID;
        public string marka;
        public string model;
        public char klasa;
        public string czas;
        public double ratio;

        public Car(int ID, string marka, string model, char klasa, string czas, double ratio)
        {
            this.ID = ID;
            this.marka = marka;
            this.model = model;
            this.klasa = klasa;
            this.czas = czas;
            this.ratio = ratio;
        }

        

        }
}
