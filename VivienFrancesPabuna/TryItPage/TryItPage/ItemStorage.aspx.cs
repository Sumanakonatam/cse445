using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part4
{
    public partial class _ItemStorage : Page
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
            InventoryService.InvService prox = new InventoryService.InvServiceClient();
            string input = this.TextBox1.Text;
            string content = prox.DecrementItemQuantity(20, 3);
            // Specifically denote that the result is displayed to avoid confusion.
            this.ResultLabel.Text = content;
        }

        // Placeholder method.
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}