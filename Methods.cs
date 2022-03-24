using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MainProgram;

namespace methods {
    public class Converters {
        private char[] perSeperator = { '.' };
        private Int32 count = 99;
        private int eightSlot;
        private int fourSlot;
        private int twoSlot;
        private int oneSlot;
        private int biTotal;
        private char switcher;

        public void ConvToHexa(string val, string type) {
            Console.ForegroundColor = ConsoleColor.Green;
            if (type == "binary" || type == "BINARY" || type == "Binary")
            {
                Int32 count = 8;
                String[] bits = val.Split(perSeperator, count, StringSplitOptions.None);
                List<char> hexas = new List<char>();

                Console.Write("Your hexadecimal is: ");
                foreach (string bit in bits)
                {
                    if (bit.Length != 4) {
                        Console.WriteLine("One of your 4-bit segments is not 4 bits!");
                        return;
                    }
                    if (bit[0] == '1')
                    {
                        eightSlot = 8;
                    }
                    else
                    {
                        eightSlot = 0;
                    }

                    if (bit[1] == '1')
                    {
                        fourSlot = 4;
                    }
                    else
                    {
                        fourSlot = 0;
                    }

                    if (bit[2] == '1')
                    {
                        twoSlot = 2;
                    }
                    else
                    {
                        twoSlot = 0;
                    }

                    if (bit[3] == '1')
                    {
                        oneSlot = 1;
                    }
                    else
                    {
                        oneSlot = 0;
                    }

                    biTotal = eightSlot + fourSlot + twoSlot + oneSlot;



                    switch (biTotal)
                    {
                        case 10:
                            switcher = 'A';
                            Console.Write(switcher);
                            break;

                        case 11:
                            switcher = 'B';
                            Console.Write(switcher);
                            break;

                        case 12:
                            switcher = 'C';
                            Console.Write(switcher);
                            break;

                        case 13:
                            switcher = 'D';
                            Console.Write(switcher);
                            break;

                        case 14:
                            switcher = 'E';
                            Console.Write(switcher);
                            break;

                        case 15:
                            switcher = 'F';
                            Console.Write(switcher);
                            break;
                        default:
                            Console.Write(biTotal);
                            break;
                    }

                    hexas.Add(switcher);


                }
            }
            else if (type == "DECIMAL" || type == "Decimal" || type == "decimal") {
                Console.WriteLine("Your Hexadecimal number is: ");
                val.Trim();
                int dec = int.Parse(val);
                
                List<int> hexNums = new List<int>();
                while (dec > 0) {
                    int remainder = dec % 16;
                    hexNums.Add(remainder);
                    dec = dec / 16;
                    
                }

                hexNums.Reverse();

                foreach (int i in hexNums) {
                    switch (i)
                    {
                        case 10:
                            Console.Write('A');
                            break;
                        case 11:
                            Console.Write('B');
                            break;
                        case 12:
                            Console.Write('C');
                            break;
                        case 13:
                            Console.Write('D');
                            break;
                        case 14:
                            Console.Write('E');
                            break;
                        case 15:
                            Console.Write('F');
                            break;
                        default:
                            Console.Write(i);
                            break;
                    }
                }

            }
            
        }

        public void ConvToBinary(string val, string type) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (type == "hexadecimal" || type == "Hexadecimal" || type == "HEXADECIMAL")
            {
                val.Trim();

                Dictionary<char, string> d = new Dictionary<char, string> {
                {'A',"1010" },
                {'B',"1011" },
                {'C',"1100" },
                {'D',"1101" },
                {'E',"1110" },
                {'F',"1111" },
                {'a',"1010" },
                {'b',"1011" },
                {'c',"1100" },
                {'d',"1101" },
                {'e',"1110" },
                {'f',"1111" },
                };

                Dictionary<char, string> y = new Dictionary<char, string> {
                {'0',"0000" },
                {'1',"0001" },
                {'2',"0010" },
                {'3',"0011" },
                {'4',"0100" },
                {'5',"0101" },
                {'6',"0110" },
                {'7',"0111" },
                {'8',"1000" },
                {'9',"1001" },
                };

                Console.Write("\nYour binary is: ");

                foreach (char i in val)
                {
                    if (d.ContainsKey(i))
                    {
                        Console.Write(d[i]);
                        Console.Write(" ");
                    }
                    else if (y.ContainsKey(i))
                    {
                        Console.Write(y[i]);
                        Console.Write(" ");
                    }
                }

            }
            else if (type == "decimal" || type == "Decimal" || type == "DECIMAL") {

                val.Trim();
                String[] octets = val.Split(perSeperator, count, StringSplitOptions.None);
                Console.Write("\nYour binary number is:");

                foreach (string octet in octets) {
                    int value = Convert.ToInt32(octet);
                    string binaryOutput = "0000 0000";
                    StringBuilder bO = new StringBuilder(binaryOutput);

                    while (value > 0)
                    {
                        if (value >= 128)
                        {
                            bO[0] = '1';
                            value -= 128;
                            continue;
                        }
                        else if (value >= 64 && value < 128)
                        {
                            bO[1] = '1';
                            value -= 64;
                            continue;
                        }
                        else if (value >= 32 && value < 64)
                        {
                            bO[2] = '1';
                            value -= 32;
                            continue;
                        }
                        else if (value >= 16 && value < 32)
                        {
                            bO[3] = '1';
                            value -= 16;
                            continue;
                        }
                        else if (value >= 8 && value < 16)
                        {
                            bO[5] = '1';
                            value -= 8;
                            continue;
                        }
                        else if (value >= 4 && value < 8)
                        {
                            bO[6] = '1';
                            value -= 4;
                            continue;
                        }
                        else if (value >= 2 && value < 4)
                        {
                            bO[7] = '1';
                            value -= 2;
                            continue;
                        }
                        else if (value >= 1 && value < 2)
                        {
                            bO[8] = '1';
                            value -= 1;
                            continue;
                        }

                    }

                    Console.Write("\n" + bO);

                }
            }
        }

        public void ConvToDec(string val, string type) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (type == "hexadecimal" || type == "Hexadecimal" || type == "HEXADECIMAL")
            {
                val.Trim();
                int hexaPower = val.Length - 1;
                int total = 0;

                foreach (char i in val)
                {
                    int numConv;
                    if (Char.IsNumber(i))
                    {
                        numConv = Convert.ToInt32(Char.GetNumericValue(i) * Math.Pow(16, hexaPower));
                        total = total + numConv;
                        hexaPower -= 1;
                    }
                    else if (Char.IsLetter(i))
                    {

                        switch (i)
                        {

                            case 'A':
                                numConv = Convert.ToInt32(10 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'a':
                                numConv = Convert.ToInt32(10 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'B':
                                numConv = Convert.ToInt32(11 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'b':
                                numConv = Convert.ToInt32(11 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'C':
                                numConv = Convert.ToInt32(12 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'c':
                                numConv = Convert.ToInt32(12 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'D':
                                numConv = Convert.ToInt32(13 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'd':
                                numConv = Convert.ToInt32(13 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'E':
                                numConv = Convert.ToInt32(14 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'e':
                                numConv = Convert.ToInt32(14 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'F':
                                numConv = Convert.ToInt32(15 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;
                            case 'f':
                                numConv = Convert.ToInt32(15 * Math.Pow(16, hexaPower));
                                total = total + numConv;
                                hexaPower -= 1;
                                break;

                            default:
                                break;
                        }
                    }
                }
                Console.WriteLine("Your decimal number is: ");
                Console.Write(total);
            }
            else if (type == "BINARY" || type == "Binary" || type == "binary") {
                val.Trim();
                String[] eightBits = val.Split(perSeperator, count, StringSplitOptions.None);
                int stringPosition = eightBits.Length;
                Console.WriteLine("Your decimal number is: ");

                foreach (string i in eightBits) {
                    stringPosition -= 1;
                    if (i.Length != 8)
                    {
                        Console.WriteLine("The length of one of 8-bit segments was not 8! Make sure every 8 bits is separated with a period (.)!\n");
                        return;
                    }
                    else {
                        double total = 0;
                        double max = 128;
                        foreach (char a in i)
                        {

                            if (Char.GetNumericValue(a) == 1)
                            {
                                total += max;
                            }
                            max /= 2;
                        }

                        if (stringPosition == 0)
                        {
                            Console.Write(total);
                        }
                        else {
                            Console.Write(total + ".");
                        }
                        
                    }
                }
            }


        }

        public void ConvToOctal ( string val, string type )
        {
            if ( type.ToLower().Equals("decimal") )
            {
                int num = Convert.ToInt32(val);
                int remainder = 0;
                string collecter = "";

                while ( num > 0 )
                {
                    remainder = num % 8;
                    num /= 8;
                    collecter = remainder.ToString() + collecter;
                }

                Console.WriteLine("Your Octal Value is: {0}", collecter);
            }
        }
    }
}