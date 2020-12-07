using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics
{
    class EGNMethods
    {
        public static bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool CorrectDate(string egn)
        {
            int month = int.Parse(egn.Substring(2, 2));
            int date = int.Parse(egn.Substring(4, 2));
            if (!((month >= 1 && month <= 12) || (month >= 21 && month <= 32) || (month >= 41 && month <= 52)))
            {
                Console.WriteLine("Invalid month. Positions 3 and 4.");
                return false;
            }
            if (date < 1 || date > 31)
            {
                Console.WriteLine("Invalid day. Positions 5 and 6.");
                return false;
            }
            return true;
        }

        public static bool IsEGN(int[] egnarray, string egn)
        {
            int[] coeff = new int[10] { 2, 4, 8, 5, 10, 9, 7, 3, 6, 0 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += egnarray[i] * coeff[i];
            }
            sum = sum % 11;
            if (sum == 10)
                sum = 0;

            if (sum == int.Parse(egn.Substring(9, 1)))
                return true;
            else
            {
                Console.WriteLine("Wrong digit at position 10");
                return false;
            }
        }
    }
}
