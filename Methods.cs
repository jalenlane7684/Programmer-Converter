using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MainProgram;

namespace Methods {
    public static class Converters {
        private static char[] perSeperator = { '.' };
        private static Int32 count = 99;
        private static int eightSlot;
        private static int fourSlot;
        private static int twoSlot;
        private static int oneSlot;
        private static int biTotal;
        private static char switcher;

        public static string ConvToHexa (string val, string type) {
            Console.ForegroundColor = ConsoleColor.Green;
            string result = "";
            if (type == "binary" || type == "BINARY" || type == "Binary")
            {
                Int32 count = 8;
                String[] bits = val.Split(perSeperator, count, StringSplitOptions.None);
                List<char> hexas = new List<char>();
                

                foreach (string bit in bits)
                {
                    if (bit.Length != 4) {
                        Console.WriteLine("One of your 4-bit segments is not 4 bits!");
                        return "";
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
                            result = result + switcher;
                            break;

                        case 11:
                            switcher = 'B';
                            result = result + switcher;
                            break;

                        case 12:
                            switcher = 'C';
                            result = result + switcher;
                            break;

                        case 13:
                            switcher = 'D';
                            result = result + switcher;
                            break;

                        case 14:
                            switcher = 'E';
                            result = result + switcher;
                            break;

                        case 15:
                            switcher = 'F';
                            result = result + switcher;
                            break;
                        default:
                            result = result + switcher;
                            break;
                    }

                    hexas.Add(switcher);


                }
            }
            else if (type == "DECIMAL" || type == "Decimal" || type == "decimal") {
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
                            result = result + 'A';
                            break;
                        case 11:
                            result = result + 'B';
                            break;
                        case 12:
                            result = result + 'C';
                            break;
                        case 13:
                            result = result + 'D';
                            break;
                        case 14:
                            result = result + 'E';
                            break;
                        case 15:
                            result = result + 'F';
                            break;
                        default:
                            result = result + i; ;
                            break;
                    }
                }

            }

            return result;
        }

        public static string ConvToBinary ( string val, string type ) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string result = "";
            if ( type.ToLower().Equals("hexadecimal"))
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




                foreach ( char i in val )
                {
                    if ( d.ContainsKey(i) )
                    {
                        result = result + d[i];
                        result = result + " ";
                    }
                    else if ( y.ContainsKey(i) )
                    {
                        result = result + y[i];
                        result = result + " ";
                    }
                }

            }
            else if ( type.ToLower().Equals("decimal") ) {

                val.Trim();
                String[] octets = val.Split(perSeperator, count, StringSplitOptions.None);

                foreach ( string octet in octets ) {
                    int value = Convert.ToInt32(octet);
                    string binaryOutput = "0000 0000";
                    StringBuilder bO = new StringBuilder(binaryOutput);

                    while ( value > 0 )
                    {
                        if ( value >= 128 )
                        {
                            bO[0] = '1';
                            value -= 128;
                            continue;
                        }
                        else if ( value >= 64 && value < 128 )
                        {
                            bO[1] = '1';
                            value -= 64;
                            continue;
                        }
                        else if ( value >= 32 && value < 64 )
                        {
                            bO[2] = '1';
                            value -= 32;
                            continue;
                        }
                        else if ( value >= 16 && value < 32 )
                        {
                            bO[3] = '1';
                            value -= 16;
                            continue;
                        }
                        else if ( value >= 8 && value < 16 )
                        {
                            bO[5] = '1';
                            value -= 8;
                            continue;
                        }
                        else if ( value >= 4 && value < 8 )
                        {
                            bO[6] = '1';
                            value -= 4;
                            continue;
                        }
                        else if ( value >= 2 && value < 4 )
                        {
                            bO[7] = '1';
                            value -= 2;
                            continue;
                        }
                        else if ( value >= 1 && value < 2 )
                        {
                            bO[8] = '1';
                            value -= 1;
                            continue;
                        }

                    }

                    result = result + "\n" + bO;

                }
            }
            else if ( type.ToLower().Equals("octaldecimal") )
            {
                val = ConvToDec(val, type);
                val.Trim();
                String[] octets = val.Split(perSeperator, count, StringSplitOptions.None);

                foreach ( string octet in octets )
                {
                    int value = Convert.ToInt32(octet);
                    string binaryOutput = "0000 0000";
                    StringBuilder bO = new StringBuilder(binaryOutput);

                    while ( value > 0 )
                    {
                        if ( value >= 128 )
                        {
                            bO[0] = '1';
                            value -= 128;
                            continue;
                        }
                        else if ( value >= 64 && value < 128 )
                        {
                            bO[1] = '1';
                            value -= 64;
                            continue;
                        }
                        else if ( value >= 32 && value < 64 )
                        {
                            bO[2] = '1';
                            value -= 32;
                            continue;
                        }
                        else if ( value >= 16 && value < 32 )
                        {
                            bO[3] = '1';
                            value -= 16;
                            continue;
                        }
                        else if ( value >= 8 && value < 16 )
                        {
                            bO[5] = '1';
                            value -= 8;
                            continue;
                        }
                        else if ( value >= 4 && value < 8 )
                        {
                            bO[6] = '1';
                            value -= 4;
                            continue;
                        }
                        else if ( value >= 2 && value < 4 )
                        {
                            bO[7] = '1';
                            value -= 2;
                            continue;
                        }
                        else if ( value >= 1 && value < 2 )
                        {
                            bO[8] = '1';
                            value -= 1;
                            continue;
                        }

                    }

                    result = result + "\n" + bO;
                }
            }
            return result;
        }

        public static string ConvToDec ( string val, string type )
        {

            string result = "";
            Console.ForegroundColor = ConsoleColor.Yellow;
            if ( type.ToLower().Equals("hexadecimal") )
            {
                val.Trim();
                int hexaPower = val.Length - 1;
                int total = 0;

                foreach ( char i in val )
                {
                    int numConv;
                    if ( Char.IsNumber(i) )
                    {
                        numConv = Convert.ToInt32(Char.GetNumericValue(i) * Math.Pow(16, hexaPower));
                        total = total + numConv;
                        hexaPower -= 1;
                    }
                    else if ( Char.IsLetter(i) )
                    {

                        switch ( i )
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
                result = total.ToString();
            }
            else if ( type.ToLower().Equals("binary") )
            {
                val.Trim();
                String[] eightBits = val.Split(perSeperator, count, StringSplitOptions.None);
                int stringPosition = eightBits.Length;

                foreach ( string i in eightBits )
                {
                    stringPosition -= 1;
                    if ( i.Length != 8 )
                    {
                        Console.WriteLine("The length of one of 8-bit segments was not 8! Make sure every 8 bits is separated with a period (.)!\n");
                    }
                    else
                    {
                        double total = 0;
                        double max = 128;
                        foreach ( char a in i )
                        {

                            if ( Char.GetNumericValue(a) == 1 )
                            {
                                total += max;
                            }
                            max /= 2;
                        }

                        if ( stringPosition == 0 )
                        {
                            result = result + total.ToString();

                        }
                        else
                        {
                            result = result + total.ToString() + ".";
                        }

                    }
                }
            }
            else if ( type.ToLower().Equals("octaldecimal"))
            {
                int total = 0;
                for (int i = val.Length - 1; i >= 0; i-- )
                {
                    total = total + (int)Math.Pow(Convert.ToInt32(val.Substring(i, 1)), i);
                }

                result = total.ToString();
            }
            return result;

        }

        public static string ConvToOctal ( string val, string type )
        {
            string result = "";
            string converted = "";

            if (type.ToLower().Equals("binary") || type.ToLower().Equals("decimal")  || type.ToLower().Equals("hexadecimal") )
            {
                converted = ConvToDec(val, type);
                int num = Convert.ToInt32(val);
                int remainder = 0;

                while ( num > 0 )
                {
                    remainder = num % 8;
                    num /= 8;
                    result = remainder.ToString() + result;
                }
            } else
            {
                Console.WriteLine("You did not use one of the listed value types. Please convert from binary, decimal, or hexadecimal.");
            }

            return result;
        }
    }
}