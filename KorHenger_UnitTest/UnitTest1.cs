using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;

namespace KorHenger_UnitTest
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör(sugár);
            kör.SetKerület();
            double 
            // Act - Végrehajtás

            // Assert - Kiértékelés
        }

        [TestMethod]
        public void Terület_teszt()
        {
        }
    }
}
