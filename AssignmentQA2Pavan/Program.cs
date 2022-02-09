using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQA2Pavan
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.go();
        }

        public void go()
        {
            string strCel, strKel, strFhr;
            double celsius, kelvin, farh;
            Conversion conver;
            do
            {
                Console.Write("Enter Temperature in Celsius: ");
                strCel = Console.ReadLine();

            } while (!double.TryParse(strCel, out celsius) || (celsius <= 0));
            do
            {
                Console.Write("Enter Temperature in Kelvin: ");
                strKel = Console.ReadLine();

            } while (!double.TryParse(strKel, out kelvin) || (kelvin <= 0));
            do
            {
                Console.Write("Enter Temperature in Fahrenheit: ");
                strFhr = Console.ReadLine();

            } while (!double.TryParse(strFhr, out farh) || (farh <= 0));
            conver = new Conversion(celsius, kelvin, farh);

            int option = 0;
            string clientOption;
            do
            {
                do
                {
                    Console.Write("\n1. Convert Celsius to Fahrenheit");
                    Console.Write("\n2. Convert Celsius to Kelvin");
                    Console.Write("\n3. Convert Fahrenheit to Celsius");
                    Console.Write("\n4. Convert Fahrenheit to Kelvin");
                    Console.Write("\n5. Convert Kelvin to Celsius");
                    Console.Write("\n6. Convert Kelvin to Fahrenheit");
                    Console.Write("\n7. Exit");
                    Console.Write("\nSelect your Option[1-7] : ");
                    clientOption = Console.ReadLine();
                } while (!int.TryParse(clientOption, out option) || (option <= 0 || option > 8));

                switch (option)
                {
                    case 1:
                        Console.Write("\n Temperature in Celsius to Fahrenheit: " + conver.ConvertCelciusToFahrenheit());
                        break;
                    case 2:
                        Console.Write("\n Temperature in Celsius to Kelvin: " + conver.ConvertCelciusToKelvin());
                        break;
                    case 3:
                        Console.Write("\n Temperature in Fahrenheit to Celsius: " + conver.ConvertFahrenheitToCelsius());

                        break;
                    case 4:
                        Console.Write("\n Temperature in Fahrenheit to Kelvin: " + conver.ConvertFahrenheitToKelvin());
                        break;
                    case 5:
                        Console.Write("\n Temperature in Kelvin to Celsius: " + conver.ConvertKelvinToCelsius());
                        break;
                    case 6:
                        Console.Write("\n Temperature in Kelvin to Fahrenheit: " + conver.ConvertKelvinToFahrenheit());
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;

                }
            } while (true);
        }
    }
}
