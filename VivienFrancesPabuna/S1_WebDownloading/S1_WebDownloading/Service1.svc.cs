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
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();

            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
            }

            List<int> indices = new List<int>();
            List<string> titles = new List<string>();
            int pos = -1, count = 0;

            while ((pos = html.IndexOf("main_title", pos + 1)) != -1)
            {
                count++;
                indices.Add(pos);
                titles.Add(html.Substring(pos, 200));
            }

            return count.ToString() + " - " + string.Join(" ,", titles.ToArray());
        }

    }
}
