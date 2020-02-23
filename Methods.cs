using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DecimalBinary_Converter;

namespace methods {
    public class Methods {
        public char[] seperator = { ' ' };
        public Int32 count = 8;
        public List<char> hexas = new List<char>();
        public int eightSlot;
        public int fourSlot;
        public int twoSlot;
        public int oneSlot;
        public int biTotal;
        public char switcher;
        public char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
        public char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};


        public void ConvToHexa(string binary) {
            char[] seperator = { ' ' };
            Int32 count = 8;
            String[] bits = binary.Split(seperator, count, StringSplitOptions.None);
            List<char> hexas = new List<char>();

            Console.Write("Your hexadecimal is: ");
            foreach (string bit in bits) {
                if (bit[0] == '1')
                {
                    eightSlot = 8;
                }
                else {
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

                

                switch (biTotal) {
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

        public void ConvToBinary(string hexdec) {
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

            foreach (char i in hexdec) {
                if (d.ContainsKey(i))
                {
                    Console.Write(d[i]);
                    Console.Write(" ");
                }
                else if (y.ContainsKey(i)) {
                    Console.Write(y[i]);
                    Console.Write(" ");
                }
            }

        }
    }
}