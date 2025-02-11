using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                // Preguntar al usuario la unidad de conversión
                Console.WriteLine("Choose the unit you want to convert from:");
                Console.WriteLine("1. Seconds");
                Console.WriteLine("2. Minutes");
                Console.Write("Enter your choice (1 or 2): ");
                string unitChoice = Console.ReadLine();

                // Preguntar al usuario la cantidad
                Console.Write("Enter the quantity: ");
                string quantityInput = Console.ReadLine();
                double quantity = double.Parse(quantityInput);

                // Realizar la conversión basada en la elección del usuario
                double result = 0; // Inicializar la variable con un valor predeterminado
                bool validChoice = true; // Bandera para verificar si la elección es válida

                if (unitChoice == "1")
                {
                    result = HadaP1.SecondsToMinutes(quantity);
                    Console.WriteLine($"{quantity} seconds is equal to {result} minutes.");
                }
                else if (unitChoice == "2")
                {
                    result = HadaP1.MinutesToSeconds(quantity);
                    Console.WriteLine($"{quantity} minutes is equal to {result} seconds.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    validChoice = false; // La elección no es válida
                }

                // Preguntar al usuario si desea realizar otra conversión solo si la elección fue válida
                if (validChoice)
                {
                    Console.Write("Do you want to perform another conversion? (yes/no): ");
                    userInput = Console.ReadLine().ToLower();
                }
                else
                {
                    userInput = "yes"; // Continuar el bucle si la elección no fue válida
                }

            } while (userInput == "yes");

            Console.WriteLine("Thank you for using the conversion tool!");
        }
    }
}