using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Counting_systems_transmission
{
    static class Translator
    {
        public static string Translate(string number, int from, int to, string method)
        {
            try
            {
                if (method == "div")
                    return division(number, from, to);
                if (method == "sub")
                    return subtraction(number, from, to);
                if (method == "mul")
                    return multiplication(number, from, to);
                if (method == "bit")
                    return bitwise(number, from, to);
                if (method == "tab")
                    return table(number, from, to);
                if (method == "com")
                    return combinations(number, from, to);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return "Choose the method";
        }

        private static string division(string number, int from, int to)
        {
            if (from == to)
                return number;
            if (from != 10 || isFraction(number))
                throw new ArgumentException("Division method can be used only for such translation as: 10 -> 2, 10 -> 8, 10 -> 16 and doesn't work with fractions");

            int num = Convert.ToInt32(number);
            if (num == 0)
                return "0";
            string temp = "";
            while (num > 0)
            {
                if (num % to > 9)
                    temp += (char)(num % to + 55);
                else
                    temp += num % to;
                num /= to;
            }
            string res = "";
            for (int i = temp.Length - 1; i >= 0; i--)
                res += temp[i];
            return res;
        }

        private static string subtraction(string number, int from, int to)
        {
            if (from == to)
                return number;
            if (from != 10 || to != 2)
                throw new ArgumentException("Subtraction method can be used only for such translation as: 10 -> 2");

            string result = "";
            string exponent = "";
            string mantissa = "";

            string[] expAndMant = number.Split(',');

            int exp = Convert.ToInt32(expAndMant[0]);
            int currentPow = getMaxPow(exp);
            int prevPow = 0;
            int zeros = 0;             
            if (exp == 0)
                exponent += "0";
            while (exp != 0)
            {
                exponent += "1";
                exp -= (int)Math.Pow(2, currentPow);
                prevPow = currentPow;
                currentPow = getMaxPow(exp);
                zeros = prevPow - currentPow;
                for (int i = 1; i < zeros; i++)
                    exponent += "0";
            }
            prevPow = currentPow;
            currentPow = getMaxPow(exp);
            zeros = prevPow - currentPow;
            for (int i = 1; i < zeros; i++)
                exponent += "0";

            if(expAndMant.Length == 2)
            {
                double man = Convert.ToDouble("0," + expAndMant[1]);
                mantissa += ",";

                currentPow = getMaxPowOfMantissa(man);
                prevPow = 0;
                zeros = 0;
                if (man == 0)
                    mantissa += "0";
                while (man != 0)
                {
                    if (mantissa.Length > 10)
                        break;
                    zeros = prevPow - currentPow;
                    for (int i = 1; i < zeros; i++)
                        mantissa += "0";
                    mantissa += "1";
                    man -= Math.Pow(2, currentPow);
                    prevPow = currentPow;
                    currentPow = getMaxPowOfMantissa(man);
                    
                }
            }
            return exponent + mantissa;
        }

        private static int getMaxPowOfMantissa(double x)
        {
            int temp = -1;
            while (x - Math.Pow(2, temp) < 0)
                temp--;
            return temp;
        }

        private static int getMaxPow(int x)
        {
            int temp = 0;
            while ((int)Math.Pow(2, temp) <= x)
                temp++;
            return temp - 1;
        }

        private static string multiplication(string number, int from, int to)
        {
            if (from == to)
                return number;
            if (from != 10 || (isFraction(number) && Convert.ToDouble(number) > 1))
                throw new ArgumentException
                    ("Multiplication method can be used only for such translation as: 10 -> 2, 10 -> 8, 10 -> 16 and works only with fractions that less then one");

            double num = Convert.ToDouble(number);
            if (num == 0)
                return "0";
            string res = "0,";
            for(int i = 0; i < 7; i++)
            {
                num = num * to;
                if((int) num > 9)
                    res += (char)((int)num + 55);
                else
                    res += (int)num;
                if ((int)num > 0)
                    num -= (int)num;
                if (num == 0)
                    break;
            }
            return res;
        }

        private static string bitwise(string number, int from, int to)
        {
            if (from == to)
                return number;
            if (to != 10)
                throw new ArgumentException("Division method can be used only for such translation as: 2 -> 10, 8 -> 10, 16 -> 10");

            string exponent = "";
            string mantissa = "";
            if (number.Split(',').Length > 1)
            {               
                exponent = number.Split(',')[0];
                mantissa = number.Split(',')[1];
            }
            else
                exponent = number;

            int resExp = 0;
            double resMan = 0;

            int j = 0;
            int currentNum = 0;
            for (int i = exponent.Length-1; i >= 0; i--)
            {
                currentNum = exponent[i];
                if (currentNum > 64)
                    currentNum -= 55;
                else
                    currentNum -= 48;
                resExp += currentNum * (int)Math.Pow(from, j);
                j++;
            }
            int n = -1;
            for (int i = 0; i < mantissa.Length; i++)
            {
                currentNum = mantissa[i];
                if (currentNum > 64)
                    currentNum -= 55;
                else
                    currentNum -= 48;
                resMan += currentNum * Math.Pow(from, n);
                n--;
            }
            return (resExp + resMan).ToString();

        }

        private static string table(string number, int from, int to)
        {
            if (from == to)
                return number;
            if ((from == 10 || to == 10) || (from == 8 && to == 16) || (from == 16 && to == 8) || isFraction(number))
                throw new ArgumentException
                    ("Table method can be used only for such translation as: 2 -> 8, 8 -> 2, 2 -> 16, 16 -> 2 and doesn't work with fractions");

            string result = "";
            if (from == 2 && to == 8)
            {               
                List<string> triads = new List<string>();

                while (number.Length % 3 != 0)
                    number = "0" + number;

                for(int i = 0; i < number.Length; i+=3)
                {
                    triads.Add(number.Substring(i, 3));           
                }
                foreach (string triad in triads)
                {
                    switch(triad)
                    {
                        case "000": result += "0"; break;
                        case "001": result += "1"; break;
                        case "010": result += "2"; break;
                        case "011": result += "3"; break;
                        case "100": result += "4"; break;
                        case "101": result += "5"; break;
                        case "110": result += "6"; break;
                        case "111": result += "7"; break;
                    }
                }
            }        

            if (from == 8 && to == 2)
            {
                foreach(char ch in number)
                {
                    switch (ch.ToString())
                    {
                        case "0": result += "000"; break;
                        case "1": result += "001"; break;
                        case "2": result += "010"; break;
                        case "3": result += "011"; break;
                        case "4": result += "100"; break;
                        case "5": result += "101"; break;
                        case "6": result += "110"; break;
                        case "7": result += "111"; break;
                    }
                }
                for (int i = 0; i < result.Length; i++)
                    if (result[i].Equals('1'))
                    {
                        if(i > 0)
                            result = result.Substring(i);
                        break;
                    }

            }
            if (from == 2 && to == 16)
            {
                List<string> tetrads = new List<string>();

                while (number.Length % 4 != 0)
                    number = "0" + number;

                for (int i = 0; i < number.Length; i += 4)
                {
                    tetrads.Add(number.Substring(i, 4));
                }
                foreach (string triad in tetrads)
                {
                    switch (triad)
                    {
                        case "0000": result += "0"; break;
                        case "0001": result += "1"; break;
                        case "0010": result += "2"; break;
                        case "0011": result += "3"; break;
                        case "0100": result += "4"; break;
                        case "0101": result += "5"; break;
                        case "0110": result += "6"; break;
                        case "0111": result += "7"; break;
                        case "1000": result += "8"; break;
                        case "1001": result += "9"; break;
                        case "1010": result += "A"; break;
                        case "1011": result += "B"; break;
                        case "1100": result += "C"; break;
                        case "1101": result += "D"; break;
                        case "1110": result += "E"; break;
                        case "1111": result += "F"; break;
                    }
                }

            }
            if (from == 16 && to == 2)
            {
                foreach (char ch in number)
                {
                    switch (ch.ToString())
                    {
                        case "0": result += "0000"; break;
                        case "1": result += "0001"; break;
                        case "2": result += "0010"; break;
                        case "3": result += "0011"; break;
                        case "4": result += "0100"; break;
                        case "5": result += "0101"; break;
                        case "6": result += "0110"; break;
                        case "7": result += "0111"; break;
                        case "8": result += "1000"; break;
                        case "9": result += "1001"; break;
                        case "A": result += "1010"; break;
                        case "B": result += "1011"; break;
                        case "C": result += "1100"; break;
                        case "D": result += "1101"; break;
                        case "E": result += "1110"; break;
                        case "F": result += "1111"; break;
                    }
                }
                for (int i = 0; i < result.Length; i++)
                    if (!result[i].Equals('0'))
                    {
                        if (i > 0)
                            result = result.Substring(i);
                        break;
                    }
            }

            return result;
        }

        private static string combinations(string number, int from, int to)
        {
            if (from == to)
                return number;
            if ((from == 10 && to == 2) || (from == 2 && to == 10) || 
                (from == 2 && to == 8 && isFraction(number)) || (from == 2 && to == 16 && isFraction(number)) ||
                (from == 8 && to == 16 && isFraction(number)) || (from == 16 && to == 8 && isFraction(number)) ||
                (from == 10 && to == 16) || (from == 10 && to == 8))
                throw new ArgumentException
                    ("Combinations method can be used only for such translation as: " +
                    "8 -> 2, 2 -> 8 (factions denied), 2 -> 16(factions denied), 16 -> 2, 8 -> 16(factions denied), 16 -> 8(factions denied).");

            if(from == 8 && to == 2)
            {
                return subtraction(bitwise(number, 8, 10), 10, 2);
            }
            if (from == 2 && to == 8)
            {
                return division(bitwise(number, 2, 10), 10, 8);
            }
            if (from == 2 && to == 16)
            {
                return division(bitwise(number, 2, 10), 10, 16);
            }
            if (from == 16 && to == 2)
            {
                return subtraction(bitwise(number, 16, 10), 10, 2);
            }
            if (from == 8 && to == 16)
            {
                return division(bitwise(number, 8, 10), 10, 16);
            }
            if (from == 16 && to == 8)
            {
                return division(bitwise(number, 16, 10), 10, 8);
            }
            return "";
        }

        private static bool isFraction(string num)
        {
            if (num.Contains(".") || num.Contains(","))
                return true;
            return false;
        }
    }
}
