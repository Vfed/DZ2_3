using System;

namespace DZ2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string result = "";
                Console.Write("First : ");
                bool s1 = Double.TryParse(Console.ReadLine(), out double number1);
                Console.Write("Second : ");
                bool s2 = Double.TryParse(Console.ReadLine(), out double number2);
                Console.Write("Operation : ");
                string op = Console.ReadLine();
                string errorMessage = "";

                if (!(s1 && s2))
                {
                    errorMessage += "Incorect Numbers; ";
                }

                if (op == "+")
                {
                    result += number1 + number2;
                }
                else if (op == "-")
                {
                    result += number1 - number2;
                }
                else if (op == "*")
                {
                    result += number1 * number2;
                }
                else if (op == "/")
                {
                    if (number2 == 0 && s2)
                    {
                        errorMessage += "Divide By Zero; ";
                    }
                    else /*if (number2 != 0)*/
                    {
                        result += number1 / number2;
                    }
                }
                else
                {
                    errorMessage += "Incorect operation; ";
                }

                if (errorMessage.Length > 1)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    Console.WriteLine(result);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
