using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHenger
{
    class Kor
    {
        //Az osztály feladata egy kör területének és kerületének kiszámítása

        //Osztályváltozók
        private double sugar, kerület, terület;

        //Konstruktorok
        public Kor() { }
        public Kor(double r)
        {
            setDatas(r);
        }

        private double kalkKerulet(double r)
        {
            return Math.Round(2 * r * Math.PI, 2);
        }

        private double kalkTerulet(double r)
        {
            return Math.Round(Math.Pow(r, 2) * Math.PI, 2);
        }

        public double GetSugar() { return this.sugar;}
        public double GetKerulet() { return this.kerület;}
        public double GetTerulet() { return this.terület;}

        public void SetSugar(double r)
        {
            setDatas(r);
        }

        private void setDatas(double r)
        {
            this.sugar = r;
            this.kerület = kalkKerulet(r);
            this.terület = kalkTerulet(r);
        }
    }
}
