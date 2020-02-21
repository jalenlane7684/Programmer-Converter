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
        static void Main(string[] args)
        {
            Methods m = new Methods();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello {0}! This is a base converter. It will convert hexadecimals to decimal or binary, and vice versa for each one!", name);
            Thread.Sleep(3000);

            while (true)
            {
                Console.WriteLine("\nWhat is your value type? You can say, hexadecimal, decimal, or binary, as well as their capital and lowercase counterparts!");
                Console.WriteLine("\nIf you type 'quit', then the program will stop.");
                string valueType = Console.ReadLine();

                if (valueType == "binary" || valueType == "Binary" || valueType == "BINARY")
                {
                    Console.WriteLine("\nYou have picked binary!");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nWhat is your number? Please sepearate the number with a space every four bits. (ie 1001 1001)");
                    string number = Console.ReadLine();
                    m.ConvToHexa(number);
                    Thread.Sleep(3000);
                }
                else if (valueType == "hexadecimal" || valueType == "Hexadecimal" || valueType == "HEXADECIMAL")
                {
                    Console.WriteLine("\nI am sorry, but this has not been set up yet.");
                    continue;
                }
                else if (valueType == "decimal" || valueType == "Decimal" || valueType == "DECIMAL")
                {
                    Console.WriteLine("\nI am sorry, but this has not been set up yet.");
                    continue;
                }
                else if (valueType == "quit" || valueType == "Quit" || valueType == "QUIT") {
                    Console.WriteLine("\nHave a wonderful day!");
                    Console.WriteLine("\nPress any button to quit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
