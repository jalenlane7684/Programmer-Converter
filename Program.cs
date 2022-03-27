using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods;
using System.Threading;

namespace MainProgram
{
    static class Program
    {
        public static string intro = "\nHello {0}! This is a base converter. It will convert hexadecimals to decimal or binary, and vice versa for each one!";
        public static bool containsWrongChar = false;
        public static string valueType;
        public static string convert2;

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(intro, name);
            Thread.Sleep(2000);
            

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Program.containsWrongChar = false;
                Console.WriteLine("\nWhat is your value type? You can say, hexadecimal, decimal, or binary, as well as their capital and lowercase counterparts!");
                Console.WriteLine("\nIf you type 'quit', then the program will stop.");
                Program.valueType = Console.ReadLine();

                if ( Program.valueType.ToLower().Equals("quit") ) {
                    Console.WriteLine("\nHave a nice day!");
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("\nYou have chosen {0}. What would you like to convert this value to?", Program.valueType);
                Program.convert2 = Console.ReadLine();

                if ( Program.valueType.ToLower().Equals("binary") )
                {
                    Console.WriteLine("\nWhat is your number? If you are converting to hexadecimal, seperate every four bits with a decimal point (1001.1000). If you are converting to a decimal IP Address, seperate every EIGHT bits with a decimal point (10001010.10010001).");
                    Console.WriteLine("\nIf you do not follow these instructions, you will not get a correct value!");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach (char i in number) {
                        if (!Convert.ToString(i).Contains("1") && !Convert.ToString(i).Contains("0") && !Convert.ToString(i).Contains(".")) {
                            Console.WriteLine("\nOne of your characters is not a binary number! Please only use '1' or '0'. ");
                            Thread.Sleep(1000);
                            Program.containsWrongChar = true;
                            break;
                        }
                    }
                    if ( Program.containsWrongChar == true )
                    {
                        continue;
                    }
                    else {
                        if ( Program.convert2.ToLower().Equals("hexadecimal") )
                        {
                            Console.WriteLine("Your hexadecimal number is: {0}", Converters.ConvToHexa(number, Program.valueType));
                        }
                        else if ( Program.convert2.ToLower().Equals("decimal") )
                        {
                            Console.WriteLine("Your decimal number is: {0}", Converters.ConvToDec(number, Program.valueType));

                        } else if ( Program.convert2.ToLower().Equals("octaldecimal") )
                        {
                            Console.WriteLine("Your octaldecimal number is: {0}", Converters.ConvToOctal(number, Program.valueType));
                        }
                        else {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                    Thread.Sleep(3000);
                }

                else if ( Program.valueType.ToLower().Equals("hexadecimal") )
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
                                Program.containsWrongChar = true;
                                break;
                            }
                        }
                    }

                    if ( Program.containsWrongChar == true)
                    {
                        continue;
                    }
                    else {
                        if ( Program.convert2.ToLower().Equals("binary") )
                        {
                            Console.WriteLine("Your binary number is: {0}", Converters.ConvToBinary(number, Program.valueType));

                        }
                        else if ( Program.convert2.ToLower().Equals("decimal"))
                        {
                            Console.WriteLine("Your decimal number is: {0}", Converters.ConvToDec(number, Program.valueType));

                        } else if (Program.convert2.ToLower().Equals("octaldecimal"))
                        {
                            Console.WriteLine("Your octaldecimal number is: {0}", Converters.ConvToOctal(number, Program.valueType));
                        }
                        else {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                }

                else if ( Program.valueType.ToLower().Equals("decimal") )
                {
                    char[] decNums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
                    Console.WriteLine("\nWhat is your number? You cannot convert IP addresses to hexadecimal at this time.");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nConverting...");
                    Thread.Sleep(2000);

                    foreach ( char i in number )
                    {
                        if ( !( decNums.Contains(i) ) )
                        {
                            Console.WriteLine("\nYour number does not only contain numbers! Do not have any letters or special characters other than space ( ) or period (.) in your number.");
                            Program.containsWrongChar = true;
                            break;
                        }
                    }

                    if ( Program.containsWrongChar == true )
                    {
                        continue;
                    }
                    else
                    {
                        if ( Program.convert2.ToLower().Equals("hexadecimal") )
                        {
                            Console.WriteLine("Your hexadecimal number is: {0}", Converters.ConvToHexa(number, Program.valueType));
                        }
                        else if ( Program.convert2.ToLower().Equals("binary") )
                        {
                            Console.WriteLine("Your binary number is: {0}", Converters.ConvToBinary(number, Program.valueType));
                        }
                        else if ( Program.convert2.ToLower().Equals("octal") )
                        {
                            Console.WriteLine("Your octaldecimal number is: {0}", Converters.ConvToOctal(number, Program.valueType)); ;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not choose a convertion option!");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }

                }
                else if (Program.valueType.ToLower().Equals("octaldecimal"))
                {
                    Console.WriteLine("\nWhat is your value?");
                    string number = Console.ReadLine();

                    char[] decNums = { '1', '2', '3', '4', '5', '6', '7', '0', '.' };

                    foreach ( char i in number )
                    {
                        if ( !( decNums.Contains(i) ) )
                        {
                            Console.WriteLine("\nYour number does not only contain numbers! Do not have any letters or special characters other than space ( ) or period (.) in your number.");
                            Program.containsWrongChar = true;
                            break;
                        }
                    }

                    Console.WriteLine("Converting...");
                    Thread.Sleep(3000);
                    if (convert2.ToLower().Equals("binary"))
                    {
                        Console.WriteLine("Your binary number is: {0}", Converters.ConvToBinary(number, Program.valueType));
                    } else if (convert2.ToLower().Equals("hexadecimal"))
                    {
                        Console.WriteLine("Your hexadecimal number is: {0}", Converters.ConvToHexa(number, Program.valueType));
                    } else if (convert2.ToLower().Equals("decimal"))
                    {
                        Console.WriteLine("Your decimal number is: {0}", Converters.ConvToDec(number, Program.valueType));
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
