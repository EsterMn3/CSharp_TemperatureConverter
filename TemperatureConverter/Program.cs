using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main program loop
            while (true)
            {
                // Display menu options
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Celsius to Kelvin");
                Console.WriteLine("4. Kelvin to Celsius");
                Console.WriteLine("5. Fahrenheit to Kelvin");
                Console.WriteLine("6. Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");

                // Prompt user for choice
                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();

                // Process user choice
                switch (choice)
                {
                    case "1":
                        ConvertCelsiusToFahrenheit();
                        break;
                    case "2":
                        ConvertFahrenheitToCelsius();
                        break;
                    case "3":
                        ConvertCelsiusToKelvin();
                        break;
                    case "4":
                        ConvertKelvinToCelsius();
                        break;
                    case "5":
                        ConvertFahrenheitToKelvin();
                        break;
                    case "6":
                        ConvertKelvinToFahrenheit();
                        break;
                    case "7":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number from 1 to 7.");
                        break;
                }
            }
        }

        // Convert Celsius to Fahrenheit
        static void ConvertCelsiusToFahrenheit()
        {
            Console.Write("Enter temperature in Celsius: ");
            if (!double.TryParse(Console.ReadLine(), out double celsius))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (celsius < -273.15)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (-273.15°C).");
                return;
            }

            // Convert Celsius to Fahrenheit
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Equivalent temperature in Fahrenheit: {fahrenheit:F2} °F");
            //F2 is a format specifier that indicates that the variable fahrenheit should be a floating-point 
        }

        // Convert Fahrenheit to Celsius
        static void ConvertFahrenheitToCelsius()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            if (!double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (fahrenheit < -459.67)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (-459.67°F).");
                return;
            }

            // Convert Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Equivalent temperature in Celsius: {celsius:F2} °C");
        }

        // Convert Celsius to Kelvin
        static void ConvertCelsiusToKelvin()
        {
            Console.Write("Enter temperature in Celsius: ");
            if (!double.TryParse(Console.ReadLine(), out double celsius))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (celsius < -273.15)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (-273.15°C).");
                return;
            }

            // Convert Celsius to Kelvin
            double kelvin = celsius + 273.15;
            Console.WriteLine($"Equivalent temperature in Kelvin: {kelvin:F2} K");
        }

        // Convert Kelvin to Celsius
        static void ConvertKelvinToCelsius()
        {
            Console.Write("Enter temperature in Kelvin: ");
            if (!double.TryParse(Console.ReadLine(), out double kelvin))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (kelvin < 0)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (0 K).");
                return;
            }

            // Convert Kelvin to Celsius
            double celsius = kelvin - 273.15;
            Console.WriteLine($"Equivalent temperature in Celsius: {celsius:F2} °C");
        }

        // Convert Fahrenheit to Kelvin
        static void ConvertFahrenheitToKelvin()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            if (!double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (fahrenheit < -459.67)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (-459.67°F).");
                return;
            }

            // Convert Fahrenheit to Kelvin
            double kelvin = (fahrenheit + 459.67) * 5 / 9;
            Console.WriteLine($"Equivalent temperature in Kelvin: {kelvin:F2} K");
        }

        // Convert Kelvin to Fahrenheit
        static void ConvertKelvinToFahrenheit()
        {
            Console.Write("Enter temperature in Kelvin: ");
            if (!double.TryParse(Console.ReadLine(), out double kelvin))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if input is within valid temperature range
            if (kelvin < 0)
            {
                Console.WriteLine("Temperature cannot be below absolute zero (0 K).");
                return;
            }

            // Convert Kelvin to Fahrenheit
            double fahrenheit = kelvin * 9 / 5 - 459.67;
            Console.WriteLine($"Equivalent temperature in Fahrenheit: {fahrenheit:F2} °F");
        }
    }
}
