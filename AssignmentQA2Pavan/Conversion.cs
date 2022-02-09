using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQA2Pavan
{
    public class Conversion
    {
        private double Cel;
        private double Kel;
        private double Fhr;

        public Conversion(double c, double k, double f)
        {
            Cel = c;
            Kel = k;
            Fhr = f;
        }

        public Conversion()
        {
        }

        public void SetCel(double c)
        {
            Cel = c;
        }
        public void SetKel(double k)
        {
            Kel = k;
        }
        public void SetFhr(double f)
        {
            Fhr = f;
        }

        public double ConvertCelciusToFahrenheit()
        {
            Fhr = (Cel * 9) / 5 + 32;
            return Fhr;
        }
        public double ConvertCelciusToKelvin()
        {
            Kel = Cel + 273.15;
            return Kel;
        }
        public double ConvertKelvinToFahrenheit()
        {
            Fhr = (Kel - 273.15) * 9 / 5 + 32;
            return Fhr;
        }
        public double ConvertKelvinToCelsius()
        {
            Cel = Kel - 273.15;
            return Cel;
        }
        public double ConvertFahrenheitToKelvin()
        {
            Kel = (Fhr - 32) * 5 / 9 + 273.15;
            return Kel;
        }
        public double ConvertFahrenheitToCelsius()
        {
            Cel = (Fhr - 32) * 5 / 9;
            return Cel;
        }
    }
}
