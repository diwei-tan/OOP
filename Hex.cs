using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class Hex
    {
        String hexNum;
         public Hex()
        {
            hexNum = "";
        }
        public Hex(String x)
        {
            hexNum = x;
        }
        public String GetNum()
        {
            return hexNum;
        }
        public void AddHex(string x)
        {
            hexNum = hexNum + x;
        }

        public int ToDecimal()
        {
            int[] calculateDecimal = GroupOf4Num();
            string[] hexString = new string[hexNum.Length];
            double decimalNum = 0;
            for(int j=0; j < hexNum.Length; j++)
            {
                decimalNum = decimalNum + calculateDecimal[j] * Math.Pow(16, hexNum.Length-j-1);
            }
            return (int)decimalNum;
        }
        public string ToBinary()
        {
            int[] calculateBinary = GroupOf4Num();
            string binary = "";
            for (int i = 0; i < hexNum.Length; i++)
            {

                switch (calculateBinary[i])
                {
                    case 0:
                        binary = binary + "0000";
                        break;
                    case 1:
                        binary = binary + "0001";
                        break;
                    case 2:
                        binary = binary + "0010";
                        break;
                    case 3:
                        binary = binary + "0011";
                        break;
                    case 4:
                        binary = binary + "0100";
                        break;
                    case 5:
                        binary = binary + "0101";
                        break;
                    case 6:
                        binary = binary + "0110";
                        break;
                    case 7:
                        binary = binary + "0111";
                        break;
                    case 8:
                        binary = binary + "1000";
                        break;
                    case 9:
                        binary = binary + "1001";
                        break;
                    case 10:
                        binary = binary + "1010";
                        break;
                    case 11:
                        binary = binary + "1011";
                        break;
                    case 12:
                        binary = binary + "1100";
                        break;
                    case 13:
                        binary = binary + "1101";
                        break;
                    case 14:
                        binary = binary + "1110";
                        break;
                    case 15:
                        binary = binary + "1111";
                        break;
                }
            }
            return binary;
        }
        int[] GroupOf4Num ()
        {
            int[] calculateDecimal = new int[hexNum.Length];
            string[] hexString = new string[hexNum.Length];
            for (int i = 0; i < hexNum.Length; i++)
            {
                hexString[i] = hexNum.Substring(i, 1);
                if (int.TryParse(hexNum.Substring(i, 1), out calculateDecimal[i]) == false)
                {
                    if (hexString[i] == "A")
                        calculateDecimal[i] = 10;
                    else if (hexString[i] == "B")
                        calculateDecimal[i] = 11;
                    else if (hexString[i] == "C")
                        calculateDecimal[i] = 12;
                    else if (hexString[i] == "D")
                        calculateDecimal[i] = 13;
                    else if (hexString[i] == "E")
                        calculateDecimal[i] = 14;
                    else if (hexString[i] == "F")
                        calculateDecimal[i] = 15;
                }
            }
            return calculateDecimal;
        }

    }
}
