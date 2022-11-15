using System;
using System.Net;
using System.Collections.Generic;

/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 10/16/2022
    Assignment 5
*/

namespace Services
{
    public class Service1 : IService1
    {

        /*
            -- REQUIRED SERVICE #1 --
            This method downloads the content at a given url and 
            returns what's inside of the p, span, and div tags.

            Parameter: string url - website to download content from
            Returns: string - content at URL
        */
        public string getContent(string url)
        {
            string html;

            // Method for getting only what's inside of the tags (the text content).
            int getIndexOfNthBracket(int n, string bracket, int start)
            {
                string substr = html.Substring(start, 500);
                
                // Keep track of character occurences.
                int _pos = 0, _count = 0;
                while ((_pos = substr.IndexOf(bracket, _pos + 1)) != -1)
                {
                    _count++;
                    // If it is the nth occurence, return the global index.
                    if (_count == n) return (start + _pos);
                }
                return start;
            }

            // Create WebClient object for downloading data.
            WebClient myWebClient = new WebClient();
            byte[] myDataBuffer;

            // Handle possible scenario in which the website does not allow this extraction process.
            try
            {
                myDataBuffer = myWebClient.DownloadData(url);
            } catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            html = encoding.GetString(myDataBuffer);

            List<int> indices = new List<int>();
            List<string> titles = new List<string>();
            int pos = -1, count = 0;

            // Handle website for the vending machine's use-case:
            // informing of upcoming events for ASU students.
            string keyword = "main_title";
            if (url.Equals("https://innercircle.engineering.asu.edu/") == true)
            {
                // Take only what's inside of the main_title tag (article headers).
                while ((pos = html.IndexOf(keyword, pos + 1)) != -1)
                {
                    count++;
                    indices.Add(pos);
                    int start = getIndexOfNthBracket(2, ">", pos) + 1;
                    int length = getIndexOfNthBracket(2, "<", pos) - start;
                    string substr = html.Substring(start, length);
                    substr = System.Text.RegularExpressions.Regex.Replace(substr, @"\s+", " ");
                    if (substr.Length > 0 && substr.Equals(" ") == false)
                    {
                        titles.Add(html.Substring(start, length));
                    }
                }
            } else
            { // Handle all other website cases.
                while ((pos = html.IndexOf("<p", pos + 1)) != -1)
                {
                    try
                    {
                        count++;
                        indices.Add(pos);
                        int start = getIndexOfNthBracket(1, ">", pos) + 1;
                        int length = getIndexOfNthBracket(1, "<", pos) - start;
                        string substr = html.Substring(start, length);
                        substr = System.Text.RegularExpressions.Regex.Replace(substr, @"\s+", " ");
                        if (substr.Length > 0 && substr.Equals(" ") == false)
                        {
                            titles.Add(html.Substring(start, length));
                        }
                    }
                    catch (Exception _) { }
                }
                while ((pos = html.IndexOf("<span", pos + 1)) != -1)
                {
                    try
                    {
                        count++;
                        indices.Add(pos);
                        int start = getIndexOfNthBracket(1, ">", pos) + 1;
                        int length = getIndexOfNthBracket(1, "<", pos) - start;
                        string substr = html.Substring(start, length);
                        substr = System.Text.RegularExpressions.Regex.Replace(substr, @"\s+", " ");
                        if (substr.Length > 0 && substr.Equals(" ") == false)
                        {
                            titles.Add(html.Substring(start, length));
                        }
                    }
                    catch (Exception _) { }
                }
                while ((pos = html.IndexOf("<div", pos + 1)) != -1)
                {
                    try
                    {
                        count++;
                        indices.Add(pos);
                        int start = getIndexOfNthBracket(1, ">", pos) + 1;
                        int length = getIndexOfNthBracket(1, "<", pos) - start;
                        string substr = html.Substring(start, length);
                        substr = System.Text.RegularExpressions.Regex.Replace(substr, @"\s+", " ");
                        if (substr.Length > 0 && substr.Equals(" ") == false)
                        {
                            titles.Add(html.Substring(start, length));
                        }
                    }
                    catch (Exception _) { }
                }
            }

            // Return website content only if it is not empty.
            string result = string.Join("\n", titles.ToArray());
            if (result.Length > 0 && result.Equals(" ") == false)
            {
                return result;
            } else
            {
                return "No content (within the p, span, or div tags) was found on the page";
            }
            
        }

        // Dictionary for storing vending machine item / number mappings.
        private Dictionary<int, string> items = new Dictionary<int, string>(){
            {1, "Cheez-its"},
            {2, "Clif Bar"},
            {3, "Doritos"},
            {4, "Cheese Crisps"},
            {5, "Peanut Butter Bar"},
            {6, "Butter Popcorn"},
            {7, "BBQ Kettle Chips"},
            {8, "Bowl Noodle Soup"},
            {9, "Unsalted Trail Mix"},
            {10, "Skinny Pop Popcorn"},
            {11, "Flamin’ Hot Cheetos"},
            {12, "Fruit by the Foot"},
            {13, "Breakfast Biscuits"},
            {14, "Cup Noodles With Shrimp"},
            {15, "Blueberry Muffin"},
            {16, "Nutella & Go!"},
            {17, "Starburst Original"},
            {18, "Welch’s Fruit Snacks"},
            {19, "Reese’s Peanut Butter Cups"},
            {20, "Snickers"},
        };

        /*
            -- REQUIRED SERVICE #20 --
            This method converts a number to its corresponding words.

            Parameter: int num - vending maching keypad input
            Returns: string - words that correspond to the input number (vending machine item name)
        */
        public string number2Words(int num)
        {
            if (num == 0)
            {
                // Iterate through each vending machine item and print its corresponding number
                string output = "";
                foreach (KeyValuePair<int, string> entry in items)
                {
                    output = output + entry.Key + " : " + entry.Value + "\n";
                }
                return output;
            }
            else if (num < 1 || num > 20) // Handle invalid inputs
            {
                return "Error: Invalid entry\nPlease select from items 1 to 20";
            }
            return items[num];
        }
    }
}
