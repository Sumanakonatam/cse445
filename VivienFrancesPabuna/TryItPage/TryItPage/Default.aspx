<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Part4._Default" ValidateRequest="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 id="TitleLabel">#1 WebDownloading</h1>
        <h5 >The pre-selected link for our vending machine system's use-case has been entered below.<br />However, for demo purposes, you may also enter your own website instead. <br /><br />Please note that not all websites will store content information within within p, span, or div tags<br />(which this service extracts from in all other websites)<br /></h5>
        <h6>Good examples:</h6>
        <ul>
            <li>https://en.wikipedia.org/wiki/Vending_machine</li>
            <li>https://news.asu.edu/20221013-solutions-asu-students-come-app-idea-help-caregivers</li>
            <li>https://admission.asu.edu/coronavirus-faqs</li>
        </ul>
        <br />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="min-width: 800px" Rows="1" TextMode="MultiLine">https://innercircle.engineering.asu.edu/</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SortButton" runat="server" OnClick="Button2_Click" Text="Download" />
        </p>
        <p>&nbsp;<asp:TextBox ID="ResultLabel" runat="server" BackColor="#D7D7D7" OnTextChanged="TextBox2_TextChanged" ReadOnly="True" style="min-width: 800px" Rows="10" TextMode="MultiLine"></asp:TextBox>
        </p>
    </div>

    <div class="jumbotron">
        <h1 id="TitleLabel1">#20 Number2Words</h1>
        <h5>Enter a number from 1 to 30.</h5>
        <br />
        <p>
            <asp:TextBox ID="NumberBox" runat="server" OnTextChanged="TextBox1_TextChanged" style="min-width: 800px" Rows="1" TextMode="MultiLine">0</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ConvertButton" runat="server" OnClick="ConvertButton_Click" Text="Convert" />
        </p>
        <p>&nbsp;<asp:TextBox ID="WordsBox" runat="server" BackColor="#D7D7D7" OnTextChanged="TextBox2_TextChanged" ReadOnly="True" style="min-width: 800px" Rows="10" TextMode="MultiLine"></asp:TextBox>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
