﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Funkcjefinansowe.Tests
{
    [TestFixture]
    public class InwestycjeTests
    {
        [Test]
        public void wartoscPrzyszla_ObaParametryDouble_Calculated()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            double kwota = inw.wartoscPrzyszla(1000.0, 0.04);

            //Assert
            Assert.AreEqual(kwota, 1040.0);
        }
        [Test]
        public void wartoscPrzyszla_kwotaIntProcentDouble_Calculated()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            double kwota = inw.wartoscPrzyszla(1000.0, 0.04);

            //Assert
            Assert.AreEqual(kwota, 1040.0);
        }
        [Test]
        public void wartoscPrzyszla_KwotaDoubleProcentInt_Calculated()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            double kwota = inw.wartoscPrzyszla(1000.0, 0.04);

            //Assert
            Assert.AreEqual(kwota, 1040.0);
        }
        [Test]
        public void wartoscPrzyszla_ObaParametryInt_Calculated()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            double kwota = inw.wartoscPrzyszla(1000, 1);

            //Assert
            Assert.AreEqual(kwota, 2000.0);
        }
        [Test]
        public void wartoscPrzyszla_KwotaUjemna_Exception()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            var ex = Assert.Throws<ArithmeticException>(
            () => inw.wartoscPrzyszla(-1000.0, 0.04));

            //Assert
            Assert.That(ex.Message == "Kwota nie moze byc ujemna");
        }

        [TestCase(200, 250, 0.25)]
        [TestCase(200, 0, -1.00)]
        [TestCase(200, 250.22, 0.2511)]
        [TestCase(200.22, 250, 0.248627)]
        [TestCase(200.22, 250.22, 0.249725)]
        [TestCase(-1, 250, -251.00)]
        [TestCase(-1000, 1, -1.001)]
        [TestCase(4582.00, 8003.45, 0.746715)]
        [TestCase(2, 2, 0)]
        [TestCase(204, 0, -1.0)]

        public void wyliczStope_RozneWarosci_Calculated(double kwotaPoczatkowa, double kwotaKoncowa, double wartoscOdniesienia)
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            double kwota = inw.wyliczStope(kwotaPoczatkowa, kwotaKoncowa);

            //Assert
            Assert.AreEqual(kwota, wartoscOdniesienia);
        }
        [Test]
        public void wyliczStope_dzieleniePrzezZero_Exception()
        {
            //Arrange
            var inw = new Inwestycje();

            //Act
            var ex = Assert.Throws<ArithmeticException>(
            () => inw.wyliczStope(0, 1000.0));

            //Assert
            Assert.That(ex.Message == "Dzielenie przez zero!!!!");
        }
    }
}
