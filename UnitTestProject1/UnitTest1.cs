using Microsoft.VisualStudio.TestTools.UnitTesting;
using PonHatOOP;
using System;

namespace PonHatOOPTests
{
    [TestClass]
    public class PontHatTests
    {
        [TestMethod]
        public void TestBeallitPontszam_ValidPoints()
        {
            PontHat pontHat = new PontHat();
            pontHat.BeallitPontszam(95);
            Assert.AreEqual("Pontszám: 95, Osztályzat: 5", pontHat.Eredmeny());

            pontHat.BeallitPontszam(85);
            Assert.AreEqual("Pontszám: 85, Osztályzat: 4", pontHat.Eredmeny());

            pontHat.BeallitPontszam(70);
            Assert.AreEqual("Pontszám: 70, Osztályzat: 3", pontHat.Eredmeny());

            pontHat.BeallitPontszam(55);
            Assert.AreEqual("Pontszám: 55, Osztályzat: 2", pontHat.Eredmeny());

            pontHat.BeallitPontszam(45);
            Assert.AreEqual("Pontszám: 45, Osztályzat: 1", pontHat.Eredmeny());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBeallitPontszam_NegativePoints()
        {
            PontHat pontHat = new PontHat();
            pontHat.BeallitPontszam(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBeallitPontszam_Over100Points()
        {
            PontHat pontHat = new PontHat();
            pontHat.BeallitPontszam(101);
        }

        [TestMethod]
        public void TestBeallitPontszam_BoundaryValues()
        {
            PontHat pontHat = new PontHat();

            pontHat.BeallitPontszam(50);
            Assert.AreEqual("Pontszám: 50, Osztályzat: 1", pontHat.Eredmeny());

            pontHat.BeallitPontszam(65);
            Assert.AreEqual("Pontszám: 65, Osztályzat: 3", pontHat.Eredmeny());

            pontHat.BeallitPontszam(80);
            Assert.AreEqual("Pontszám: 80, Osztályzat: 4", pontHat.Eredmeny());

            pontHat.BeallitPontszam(90);
            Assert.AreEqual("Pontszám: 90, Osztályzat: 5", pontHat.Eredmeny());
        }
    }
}