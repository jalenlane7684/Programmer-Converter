using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            int hexaLength = hexas.Count;
            
        }

        public void ConvToBinary(string hexdec) { 
            
        }
    }
}