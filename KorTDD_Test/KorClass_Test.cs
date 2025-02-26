﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KorTDD;

namespace KorTDD_Test
{
    [TestClass]
    public class KorClass_Test
    {
        // Inicializáljuk a teszt környezetet
        KorClass kor = new KorClass(4.0);

        // Kerület tesztelése
        [TestMethod]
        public void setKerulet_teszt_True()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 25.12,
                kapottEredm;

            // Act
            kapottEredm = kor.setKerulet(sugar);

            // Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void setKerulet_teszt_False_alatt()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 25.11,
                kapottEredm;

            // Act
            kapottEredm = kor.setKerulet(sugar);

            // Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
            
        }

        [TestMethod]
        public void setKerulet_teszt_False_felett()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 25.13,
                kapottEredm;

            // Act
            kapottEredm = kor.setKerulet(sugar);

            // Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
            
        }

        [TestMethod]
        public void setTerulet_teszt_True()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 50.24,
                kapottEredm;

            // Act
            kapottEredm = kor.setTerulet(sugar);

            // Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void setTerulet_teszt_False_alatt()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 50.23,
                kapottEredm;

            // Act
            kapottEredm = kor.setTerulet(sugar);

            // Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void setTerulet_teszt_False_felett()
        {
            // Arrange
            double sugar = kor.getSugar();
            double vartEredm = 50.25,
                kapottEredm;

            // Act
            kapottEredm = kor.setTerulet(sugar);

            // Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
    }
}
