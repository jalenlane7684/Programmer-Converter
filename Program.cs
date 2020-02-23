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
        public bool containsWrongChar = false;
        static void Main(string[] args)
        {
            Program g = new Program();
            Methods m = new Methods();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello {0}! This is a base converter. It will convert hexadecimals to decimal or binary, and vice versa for each one!", name);
            Thread.Sleep(3000);
            

            while (true)
            {
                g.containsWrongChar = false;
                Console.WriteLine("\nWhat is your value type? You can say, hexadecimal, decimal, or binary, as well as their capital and lowercase counterparts!");
                Console.WriteLine("\nIf you type 'quit', then the program will stop.");
                string valueType = Console.ReadLine();

                if (valueType == "binary" || valueType == "Binary" || valueType == "BINARY")
                {
                    char[] binry = { '1', '0' };
                    Console.WriteLine("\nYou have chosen binary! Currently, you can only convet to hexadecimal.");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nWhat is your number? Please sepearate the number with a space every four bits. (ie 1001 1001)");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in number) {
                        if (!(Convert.ToString(i).Contains("1")) && !(Convert.ToString(i).Contains("0"))) {
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
                        m.ConvToHexa(number);
                    }
                    Thread.Sleep(3000);
                }
                else if (valueType == "hexadecimal" || valueType == "Hexadecimal" || valueType == "HEXADECIMAL")
                {
                    char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                    char[] letters = {'a', 'b', 'c', 'd', 'e', 'f','A','B','C','D','E','F'};
                    Console.WriteLine("\nYou have chosen hexidecimal! Currently, you can only convert to binary.");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nWhat is your hexadecimal? Please only use numbers 1-9 and letters A-F.");
                    string hexadec = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in hexadec) {
                        try
                        {
                            int index = Array.IndexOf(nums, i);
                        }
                        catch (Exception)
                        {
                            try
                            {
                                int index = Array.IndexOf(letters, i);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nYour hexadecimal does not only contain numbers and letters!");
                                Console.WriteLine("\nMake sure your hexadecimal only contains numbers 0-9, and letters A-F.");
                                break;
                                g.containsWrongChar = true;
                                
                            }
                            
                        }
                    }

                    if (g.containsWrongChar == true)
                    {
                        continue;
                    }
                    else {
                        m.ConvToBinary(hexadec);
                    }
                }
                else if (valueType == "decimal" || valueType == "Decimal" || valueType == "DECIMAL")
                {
                    Console.WriteLine("\nI am sorry, but this has not been set up yet.");
                    continue;
                }
                else if (valueType == "quit" || valueType == "Quit" || valueType == "QUIT")
                {
                    Console.WriteLine("\nHave a wonderful day!");
                    Console.WriteLine("\nPress any button to quit...");
                    Console.ReadLine();
                    break;
                }
                else {
                    Console.WriteLine("I am sorry, but that is not a valid choice...");
                    Thread.Sleep(2000);
                    continue;
                }
            }
        }
    }
}
