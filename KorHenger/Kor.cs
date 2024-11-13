using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHenger
{
    class Kör
    {
        protected double sugar,
            terület,
            kerület;

        public Kör() { }

        public Kör(double r)
        {
            this.sugar = r;
        }

        public void SetSugar(double r)
        {
            this.sugar = r;
        }

        public void SetTerület()
        {
            this.terület = Math.Round(Math.Pow(this.sugar, 2) * Math.PI, 2);
        }

        public void SetKerület()
        {
            this.kerület = Math.Round(2 * this.sugar * Math.PI, 2);
        }

        public double GetTerület()
        {
            return this.terület;
        }

        public double GetKerület()
        {
            return 2 * r * Math.PI;
        }

        public double GetSugár()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

    class Henger : Kör
    {
        // Osztályváltozók
        private double térfogat,
            magasság;

        // Konstruktor
        public Henger(double s, double m)
        {
            // Változók beállítása
            this.sugar = s;
            this.magasság = m;

            // Számítások elvégzése
            SetKerület();
            SetTerület();
            this.térfogat = this.terület * this.magasság;
        }

        public double GetTérfogat()
        {
            this.sugar;
            this.kerület = kalkKerulet(r);
            this.terület = kalkTerulet(r);
        }

    }
}