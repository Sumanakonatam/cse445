using System;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.XPath;
using System.Linq;


/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 10/16/2022
    Assignment 1, Parts 1-2
*/

namespace Assignment1
{
    public class Service1 : IService1
    {

        /*
            This method downloads the content at a given url and returns the first 20 characters.

            Parameter: string url - website to download content from
            Returns: string - content at URL
        */
        public string getContent(string url)
        {
            string html;

            int getIndexOfNthBracket(int n, string bracket, int start)
            {
                string substr = html.Substring(start, 500);
                int _pos = 0, _count = 0;
                while ((_pos = substr.IndexOf(bracket, _pos + 1)) != -1)
                {
                    _count++;
                    if (_count == n) return (start + _pos);
                }
                return start;
            }

            WebClient myWebClient = new WebClient();
            byte[] myDataBuffer;

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
            string keyword = "main_title";
            if (url.Equals("https://innercircle.engineering.asu.edu/") == true)
            {
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
            {
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

            string result = string.Join("\n", titles.ToArray());
            if (result.Length > 0 && result.Equals(" ") == false)
            {
                return result;
            } else
            {
                return "No content (within the p, span, or div tags) was found on the page";
            }
            
        }

    }
}
