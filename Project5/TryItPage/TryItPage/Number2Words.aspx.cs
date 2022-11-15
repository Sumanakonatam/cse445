using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part4
{
    public partial class _Number2Words : Page
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
            This method handles the event in which the user clicks the `Convert` button.
            Ensure that the input is in the correct number format, and print the result
                in the textbox below it.
        */
        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client prox = new ServiceReference1.Service1Client();
            int num;

            try
            {
                num = Int32.Parse(this.NumberBox.Text);
                string words = prox.number2Words(num);
                this.WordsBox.Text = words;
            }
            catch (Exception ex)
            {
                this.WordsBox.Text = "Error: " + ex.Message;
            }

        }

        // Placeholder method.
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}