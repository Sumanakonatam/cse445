using System;
using System.Collections.Generic;
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
        private Dictionary<int, string> items = new Dictionary<int, string>(){
            {1, "Cheez-its"},
            {2, "Clif Bar"},
            {3, "Doritos"},
        };

        /*
            This method converts a number to its corresponding words.

            Parameter: int num - vending maching keypad input
            Returns: string - words that correspond to the input number (vending machine item name)
        */
        public string number2Words(int num)
        {
            if (num < 1 || num > 30)
            {
                return "Error: invalid entry\nPlease select from items 1 to 30";
            }
            return items[num];
        }

    }
}
