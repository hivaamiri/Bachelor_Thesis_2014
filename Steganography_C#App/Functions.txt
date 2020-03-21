using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class Functions
    {
        public static string ConvertToBase3(int value, int toBase)
        {
            if (toBase < 2 || toBase > 36) throw new ArgumentException("toBase");
            if (value < 0) throw new ArgumentException("value");

            if (value == 0) return "0"; //0 would skip while loop

            string AlphaCodes = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string retVal = "";

            while (value > 0)
            {
                retVal = AlphaCodes[value % toBase] + retVal;
                value /= toBase;
            }
            return retVal;
        }

        public static int ConvertToBase10(string value) 
        {
            int valueLenth, retval = 0;
            valueLenth = value.Length;
            for (int x = 1; x <= valueLenth; x++)
                retval += (int)(int.Parse(value.Substring(x - 1, 1)) * Math.Pow(3, valueLenth - x));
            return retval;
        }

        public static int setPixel(int secretDigit, int colorPixel) 
        {
            if (colorPixel == 255)
                colorPixel--;
            string sw = (secretDigit - (colorPixel % 3)).ToString();
            switch (sw)
            {
                case "1":
                case "-1":
                case "0":
                    if (secretDigit < colorPixel % 3)
                        colorPixel--;
                    else if (secretDigit > colorPixel % 3)
                        colorPixel++;
                    break;

                case "2":
                case "-2":
                    if (secretDigit < colorPixel % 3)
                        colorPixel -= 2;
                    else if (secretDigit > colorPixel % 3)
                        colorPixel += 2;
                    break;
            }
            return colorPixel;
        }
    }
}
