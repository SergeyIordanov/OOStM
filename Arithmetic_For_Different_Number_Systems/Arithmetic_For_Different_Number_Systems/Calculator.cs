using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_For_Different_Number_Systems
{
    static class Calculator
    {
        public static string Calculate(string op1, string  op2, int system, char operation)
        {
            string result = "Error!";
            if(system == 2)
            {
                switch(operation)
                {
                    case '+': result = binAdd(op1, op2); break;
                    case '-': result = binSub(op1, op2); break;
                    case '*': result = binMul(op1, op2); break;
                    case '/': result = binDiv(op1, op2); break;
                }
            }
            if (system == 8)
            {
                switch (operation)
                {
                    case '+': result = octAdd(op1, op2); break;
                    case '-': result = octSub(op1, op2); break;
                    case '*': result = octMul(op1, op2); break;
                    case '/': result = octDiv(op1, op2); break;
                }
            }
            if (system == 10)
            {
                switch (operation)
                {
                    case '+': result = decAdd(op1, op2); break;
                    case '-': result = decSub(op1, op2); break;
                    case '*': result = decMul(op1, op2); break;
                    case '/': result = decDiv(op1, op2); break;
                }
            }
            if (system == 16)
            {
                switch (operation)
                {
                    case '+': result = hexAdd(op1, op2); break;
                    case '-': result = hexSub(op1, op2); break;
                    case '*': result = hexMul(op1, op2); break;
                    case '/': result = hexDiv(op1, op2); break;
                }
            }

            return result;
        }

        // Binary numbers
        private static string binAdd(string op1, string op2)
        {
            if (op1.Length > op2.Length)
                op2 = "0".PadRight((op1.Length - op2.Length), '0') + op2;
            else if (op1.Length < op2.Length)
                op1 = "0".PadRight((op2.Length - op1.Length), '0') + op1;

            string result = "";
            int inMind = 0;
            for(int i = op1.Length-1; i >= 0; i--)
            {
                if(op1[i] == '1' && op2[i] == '1')
                {
                    if(inMind == 1)
                    {
                        result = "1" + result;
                    }
                    else
                    {
                        result = "0" + result;
                    }
                    inMind = 1;
                }
                else if((op1[i] == '0' && op2[i] == '1') || (op1[i] == '1' && op2[i] == '0'))
                {
                    if (inMind == 1)
                    {
                        result = "0" + result;
                        inMind = 1;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                }
                if (op1[i] == '0' && op2[i] == '0')
                {
                    if (inMind == 1)
                    {
                        result = "1" + result;
                        inMind = 0;
                    }
                    else
                    {
                        result = "0" + result;
                    }
                }
            }
            if (inMind == 1)
                result = "1" + result;
            return result;
        }
        private static string binSub(string op1, string op2)
        {
            if (op1.Length > op2.Length)
                op2 = "0".PadRight((op1.Length - op2.Length), '0') + op2;
            else if (op1.Length < op2.Length)
                op1 = "0".PadRight((op2.Length - op1.Length), '0') + op1;

            string result = "";
            string additionalCode = "";
            foreach(char ch in op2)
            {
                if (ch == '1')
                    additionalCode += '0';
                else
                    additionalCode += '1';
            }
            additionalCode = binAdd(additionalCode, "1");
            
            result = binAdd(op1, additionalCode);
            if (result.Length > op1.Length)
                return "0|" + result.Substring(1);
            else
            {
                string finRes = "";
                result = binSub(result, "1").Substring(2);
                foreach (char ch in result)
                {
                    if (ch == '1')
                        finRes += '0';
                    else
                        finRes += '1';
                }
                return "1|" + finRes;
            }
        }
        private static string binMul(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string binDiv(string op1, string op2)
        {
            return "Unable now=)";
        }

        // Octal numbers
        private static string octAdd(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string octSub(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string octMul(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string octDiv(string op1, string op2)
        {
            return "Unable now=)";
        }

        // Decimal numbers
        private static string decAdd(string op1, string op2)
        {
            return (Convert.ToInt64(op1) + Convert.ToInt64(op2)).ToString();
        }
        private static string decSub(string op1, string op2)
        {
            return (Convert.ToInt64(op1) - Convert.ToInt64(op2)).ToString();
        }
        private static string decMul(string op1, string op2)
        {
            return (Convert.ToInt64(op1) * Convert.ToInt64(op2)).ToString();
        }
        private static string decDiv(string op1, string op2)
        {
            return (Convert.ToDouble(op1) / Convert.ToDouble(op2)).ToString();
        }

        // Hexadecimal numbers
        private static string hexAdd(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string hexSub(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string hexMul(string op1, string op2)
        {
            return "Unable now=)";
        }
        private static string hexDiv(string op1, string op2)
        {
            return "Unable now=)";
        }
    }
}
