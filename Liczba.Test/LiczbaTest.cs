using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Liczba.Test
{
    [TestFixture]
    public class LiczbaTest
    {
        [Test]
        public void IntToRoman_OutOfBoundsInteger_Exception()
        {
            //Arrange
            var num = new Liczba();
            //Act
            var ex = Assert.Throws<ArithmeticException>(
            () => num.IntToRoman(4000));
            //Assert
            Assert.That(ex.Message == "Parametr poza zakresem");
        }
        [Test]
        public void IntToRoman_WrongReturn_Calculated()
        {
            //Arrange
            var num = new Liczba();
            //Act
            String numnum = num.IntToRoman(2019);
            //Assert
            Assert.AreEqual(numnum, "MMXIX");
        }

    }
}
