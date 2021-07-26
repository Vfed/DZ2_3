using System;

namespace DZ2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            string result = "";
            bool s1 = false, s2 = false;
            double number1=0, number2=0;

            while (choice < 3)
            {
                switch (choice) 
                {
                    case 1:
                        Console.Write("First : ");
                        s1 = Double.TryParse(Console.ReadLine(), out number1);
                        break;
                    case 2:
                        s1 = Double.TryParse(result, out number1);
                        if (s1)
                        {
                            Console.WriteLine("First : " + result);
                        }
                        else 
                        {
                            Console.Write("First : ");
                            s1 = Double.TryParse(Console.ReadLine(), out number1);
                        }
                        break;
                    default:
                        break;
                }

                result = "";
                Console.Write("Second : ");
                s2 = Double.TryParse(Console.ReadLine(), out number2);
                string errorMessage = "";

                if (!(s1 && s2))
                {
                    errorMessage += "Incorect Numbers; ";
                }
                else
                {
                    Console.Write("Operation (+,-,*,/,^): ");
                    string op = Console.ReadLine();

                    switch (op)
                    {
                        case "+":
                            result += number1 + number2;
                            break;
                        case "-":
                            result += number1 - number2;
                            break;
                        case "/" when number2 != 0:
                            result += number1 / number2;
                            break;
                        case "/" when number2 == 0:
                            errorMessage += "Divide by Zero ;";
                            break;
                        case "*":
                            result += number1 * number2;
                            break;
                        case "^":
                            result += Math.Pow(number1, number2);
                            break;
                        default:
                            errorMessage += "Incorect operation; ";
                            break;
                    }
                }
                

                if (errorMessage.Length > 1)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    Console.WriteLine(result);
                }

                bool choiseKey = false;

                while (!choiseKey) 
                {
                    string choiseError = "";
                    Console.WriteLine("Chose next action (1/2/3): \n1. New operation;\n2. New operation with result;\n3. Exit;");
                    
                    bool choiseCheck = Int32.TryParse(Console.ReadLine(), out choice);
                    
                    if (choiseCheck && (choice == 1 || choice == 2 || choice == 3))
                    {
                        choiseKey = true;
                    }
                    else
                    {
                        choiseError += "Wrong choise;";
                    }

                    if (choiseError.Length > 0)
                    {
                        Console.WriteLine(choiseError);
                    }
                    Console.Clear();
                }


            }
        }
    }
}
