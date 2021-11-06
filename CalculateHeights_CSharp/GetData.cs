using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHeights_CSharp
{
    public class GetData
    {
        public double distance;
        public double height1;
        public double height2;
        public GetData()
        {
        }

        public double GetDistance()
        {
            try
            {
                Console.Write("Podaj odległość między punktami: ");
                distance = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wpisz liczbę po przecinku (lub bez)!");
                    Console.ResetColor();
                    Console.Write("Podaj odległość między punktami: ");
                } while (!double.TryParse(Console.ReadLine(), out distance));
            }

            return distance;
        }
        public double GetHeight1()
        {
            try
            {
                Console.Write("Podaj wysokość pierwszego punktu: ");
                height1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wpisz liczbę po przecinku (lub bez)!");
                    Console.ResetColor();
                    Console.Write("Podaj wysokość pierwszego punktu: ");
                } while (!double.TryParse(Console.ReadLine(), out height1));
            }

            return height1;
        }
        public double GetHeight2()
        {
            try
            {
                Console.Write("Podaj wysokość drugiego punktu: ");
                height2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wpisz liczbę po przecinku (lub bez)!");
                    Console.ResetColor();
                    Console.Write("Podaj wysokość drugiego punktu: ");
                } while (!double.TryParse(Console.ReadLine(), out height2));
            }
            return height2;
        }
    }
}
