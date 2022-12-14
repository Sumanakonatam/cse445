using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 10/16/2022
    Assignment 5
*/

namespace Part4
{
    public partial class _WebDownloading : Page
    {
        // Placeholder method.
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Placeholder method.
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
            This method handles the event in which the user clicks the `Download` button.
            The input is passed directly into the getContent service (as the service itself
                handles the error catching), and the result is displayed in the text
                box below.
        */
        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client prox = new ServiceReference1.Service1Client();
            string url = this.TextBox1.Text;
            string content = prox.getContent(url);
            // Specifically denote that the result is displayed to avoid confusion.
            this.ResultLabel.Text = content;
        }

        // Placeholder method.
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}