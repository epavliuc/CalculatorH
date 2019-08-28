using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            bool x = true;
            while (x == true)
            {
                Console.WriteLine("-      1: Calculator       -");
                Console.WriteLine("-      2: BMI              -");
                Console.WriteLine("-      3: Exit             -");

                int usrinput = Int32.Parse(Console.ReadLine());

                if (usrinput == 1)
                {
                    Calculator.Calculate();
                }
                else if (usrinput == 2)
                {
                    bmiCalc.Bmi();
                }
                else if (usrinput == 3)
                {
                    break;
                }
            }
        }
    }
    class Calculator
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter first Number: ");
            int firstNr = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator. ");
            string OP = Console.ReadLine();

            Console.WriteLine("Enter second Number: ");
            int secondNr = Int32.Parse(Console.ReadLine());

            switch (OP)
            {
                case "+":
                    Console.WriteLine("Your result is: " + (firstNr + secondNr) + "\n");
                    break;
                case "-":
                    Console.WriteLine("Your result is: " + (firstNr - secondNr) + "\n");
                    break;
                case "*":
                    Console.WriteLine("Your result is: " + (firstNr * secondNr) + "\n");
                    break;
                case "/":
                    Console.WriteLine("Your result is: " + (firstNr / secondNr) + "\n");
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }

    class bmiCalc
    {
        public static void Bmi()
        {
            Console.WriteLine("Enter Weight(kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height(m): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Your BMI is: " + (weight / (height * height)) + "\n");
        }
    }
}
