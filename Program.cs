using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using methods;
using System.Threading;

namespace DecimalBinary_Converter
{
    class Program
    {
        private const string Format = "\nHello {0}! This is a base converter. It will convert hexadecimals to decimal or binary, and vice versa for each one!";
        public bool containsWrongChar = false;
        public string valueType;
        public string convert2;

        static void Main(string[] args)
        {
            Program g = new Program();
            Methods m = new Methods();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(Format, name);
            Thread.Sleep(2000);
            

            while (true)
            {
                g.containsWrongChar = false;
                Console.WriteLine("\nWhat is your value type? You can say, hexadecimal, decimal, or binary, as well as their capital and lowercase counterparts!");
                Console.WriteLine("\nIf you type 'quit', then the program will stop.");
                g.valueType = Console.ReadLine();

                if (g.valueType == "quit" || g.valueType == "Quit" || g.valueType == "QUIT") {
                    Console.WriteLine("\nHave a nice day!");
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("\nYou have chosen {0}. What would you like to convert this value to?", g.valueType);
                g.convert2 = Console.ReadLine();

                if (g.valueType == "binary" || g.valueType == "Binary" || g.valueType == "BINARY")
                {
                    Console.WriteLine("\nWhat is your number? If you are converting to hexadecimal, seperate every four bits with a space (1001 1000). If you are converting to a decimal IP Address, seperate every EIGHT bits with a decimal point (10001010.10010001).");
                    Console.WriteLine("\nIf you do not follow these instructions, you will not get a correct value!");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in number) {
                        if (!(Convert.ToString(i).Contains("1")) && !(Convert.ToString(i).Contains("0")) && !(Convert.ToString(i).Contains("."))) {
                            Console.WriteLine("\nOne of your characters is not a binary number! Please only use '1' or '0'. ");
                            Thread.Sleep(1000);
                            g.containsWrongChar = true;
                            break;
                        }
                    }
                    if (g.containsWrongChar == true)
                    {
                        continue;
                    }
                    else {
                        if (g.convert2 == "Hexadecimal" || g.convert2 == "HEXADECIMAL" || g.convert2 == "hexadecimal")
                        {
                            m.ConvToHexa(number, g.valueType);

                        }
                        else if (g.convert2 == "Decimal" || g.convert2 == "DECIMAL" || g.convert2 == "decimal")
                        {
                            m.ConvToDec(number, g.valueType);

                        }
                        else {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                    Thread.Sleep(3000);
                }

                else if (g.valueType == "hexadecimal" || g.valueType == "Hexadecimal" || g.valueType == "HEXADECIMAL")
                {
                    char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                    char[] letters = {'a', 'b', 'c', 'd', 'e', 'f','A','B','C','D','E','F'};
                    Console.WriteLine("\nWhat is your hexadecimal? Please only use numbers 1-9 and letters A-F.");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in number) {
                        if (!(letters.Contains(i))) {
                            if (!(nums.Contains(i))) {
                                Console.WriteLine("\nSome of your characters are not 0-9 and A-F!");
                                g.containsWrongChar = true;
                                break;
                            }
                        }
                    }

                    if (g.containsWrongChar == true)
                    {
                        continue;
                    }
                    else {
                        if (g.convert2 == "BINARY" || g.convert2 == "binary" || g.convert2 == "Binary")
                        {
                            m.ConvToBinary(number, g.valueType);

                        }
                        else if (g.convert2 == "Decimal" || g.convert2 == "DECIMAL" || g.convert2 == "decimal")
                        {
                            m.ConvToDec(number, g.valueType);

                        }
                        else {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                }

                else if (g.valueType == "decimal" || g.valueType == "Decimal" || g.valueType == "DECIMAL")
                {
                    char[] decNums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
                    Console.WriteLine("\nWhat is your number? You cannot convert IP addresses to hexadecimal at this time.");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in number) {
                        if (!(decNums.Contains(i))) {
                            Console.WriteLine("\nYour number does not only contain numbers! Do not have any letters or special characters other than space ( ) or period (.) in your number.");
                            g.containsWrongChar = true;
                            break;
                        }
                    }

                    if (g.containsWrongChar == true)
                    {
                        continue;
                    }
                    else {
                        if (g.convert2 == "hexadecimal" || g.convert2 == "HEXADECIMAL" || g.convert2 == "Hexadecimal")
                        {
                            m.ConvToHexa(number, g.valueType);
                        }
                        else if (g.convert2 == "BINARY" || g.convert2 == "binary" || g.convert2 == "Binary")
                        {
                            m.ConvToBinary(number, g.valueType);
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }

                }
                else {
                    Console.WriteLine("You did not choose one of the choices specified. Please choose one of the three options specified.");
                    Thread.Sleep(2000);
                    continue;
                }
            }
        }
    }
}
