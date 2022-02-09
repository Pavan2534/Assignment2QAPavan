using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentQA2Pavan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQA2Pavan.Tests
{
    [TestClass()]
    public class Tests
    {
        public void Setup()
        {
        }
        [TestMethod()]
        public void Convert_Celcious_to_Fahrenhit()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetCel(34);
            double F = conversion.ConvertCelciusToFahrenheit();
            //ASSERT
            Assert.AreEqual(93.2, F);
        }
        [TestMethod()]
        public void Convert_Celcious_to_Kelvin()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetCel(34);
            double K = conversion.ConvertCelciusToKelvin();
            //ASSERT
            Assert.AreEqual(307.15, K);
        }

        [TestMethod()]
        public void Convert_Kelvin_to_Fahrenheit()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetKel(3000);
            double F = conversion.ConvertKelvinToFahrenheit();
            //ASSERT
            Assert.AreEqual(4940.33, F);
        }

        [TestMethod()]
        public void Convert_Kelvin_to_Celcious()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetKel(3000);
            double C = conversion.ConvertKelvinToCelsius();
            //ASSERT
            Assert.AreEqual(2726.85, C);
        }

        [TestMethod()]
        public void Convert_Fahrenheit_to_Kelvin()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetFhr(92.40008);
            double K = conversion.ConvertFahrenheitToKelvin();
            //ASSERT
            Assert.AreEqual(306.7056, K);
        }

        [TestMethod()]
        public void Convert_Fahrenheit_to_Celsius()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            conversion.SetFhr(93.2);
            double C = conversion.ConvertFahrenheitToCelsius();
            //ASSERT
            Assert.AreEqual(34, C);
        }

    }
}
