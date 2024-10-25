using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHenger
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. példány
            Kor k1 = new Kor();
            k1.SetSugar(15);
            k1.GetTerulet();
            k1.GetKerulet();

            kiír(k1);
            

            //2. példány
            Kor k2 = new Kor(58);
            k2.GetKerulet();
            k2.GetTerulet();

            kiír(k2);

            Console.ReadKey();

        }
            private static void kiír(Kor k)
        {
            Console.WriteLine($"A {k.GetSugar()} sugarú kör kerülete: {k.GetKerulet()}, területe: {k.GetTerulet()}.");
        }
        
    }
}
