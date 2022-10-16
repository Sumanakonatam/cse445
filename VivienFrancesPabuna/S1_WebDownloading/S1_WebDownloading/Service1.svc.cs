using System;
using System.Text.RegularExpressions;

/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 09/04/2022
    Assignment 1, Parts 1-2
*/

namespace Assignment1
{
    public class Service1 : IService1
    {

        /*
            This method converts temperature values in celsius to fahrenheit.

            Parameter: int originalTemp - temperature in celsius
            Returns: int - temperature in fahrenheit
        */
        public int c2f(int originalTemp)
        {
            return Convert.ToInt32((originalTemp * (9.0 / 5.0)) + 32.0);
        }

        /*
            This method converts temperature values in fahrenheit to celsius.

            Parameter: int originalTemp - temperature in fahrenheit
            Returns: int - temperature in celsius
        */
        public int f2c(int originalTemp)
        {
            return Convert.ToInt32((originalTemp - 32.0) * (5.0 / 9.0));
        }

        /*
            This method sorts a string of numbers, given that each of the numbers
                are separated by a comma. After the strings are each an element of the array,
                they are converted into doubles, and a new array is created. They are sorted
                in ascending order using the `Array.Sort` method, and formatted back into a
                unified string with commas.
            
            Parameter: string s - string consisting of numbers and commas
            Returns: string - same set of numbers in s, but sorted in ascending order
        */
        public string sort(string s)
        {
            try
            {
                if (s == null) return "";
                // Remove a possible trailing comma to prevent errors.
                s = s.TrimEnd(',');
                // Remove all whitespite to prevent errors.
                string noWhitespace = Regex.Replace(s, @"\s+", string.Empty);

                string[] splitS = noWhitespace.Split(',');
                double[] doubleS = new double[splitS.Length];
                string result = "";

                for (int i = 0; i < splitS.Length; i++)
                {
                    // Convert each string into an double value.
                    doubleS[i] = Convert.ToDouble(splitS[i]);
                }

                // Sort the doubles in ascending order using a built-in method.
                Array.Sort(doubleS);

                for (int i = 0; i < doubleS.Length; i++)
                {
                    if (i != 0)
                    {
                        result = result + ",";
                    }
                    result = result + doubleS[i].ToString();
                }

                return result;
            }
            catch (Exception)
            {
                return "ERROR: please enter valid numbers only";
            }
        }
    }
}
