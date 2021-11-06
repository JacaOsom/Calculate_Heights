using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHeights_CSharp
{
    public class CalculatorManagement : GetData
    {
        public void GetPoints()
        {
            GetDistance();
            GetHeight1();
            GetHeight2();
        }
        public void Heights()
        {
            int start = 1;
            double result, diffHeight = height1 - height2;
            Console.WriteLine("Wysokości do 2 metry: ");
            for (int i = 2; i < distance; i += 2)
            {
                result = Math.Round(((diffHeight * i) / distance), 2);
                Console.WriteLine($"H{start++} = {height1 - result}");
            }
        }
        public void GetTask()
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Wybierz działanie:\n1-Oblicz wysokości.\n0-Zakończ program.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wpisz 1 lub 0!");
                        Console.ResetColor();
                        Console.WriteLine("Wybierz działanie:\n1-Oblicz wysokości.\n0-Zakończ program.");
                    } while (!int.TryParse(Console.ReadLine(), out choice));

                }

                switch (choice)
                {
                    case 1:
                        GetPoints();
                        Heights();
                        break;
                    case 0:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wpisz 1 lub 0!");
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);

        }
        public void AutorAndHello()
        {
            Console.WriteLine("\t\tWitaj w programie do obliczania rzędnych!");
            Console.Write("\t\tAutor:");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Jacek Filipski");
            Console.ResetColor();

            Console.Write("\t\tVersion: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.0\n");
            Console.ResetColor();
        }
    }
}
