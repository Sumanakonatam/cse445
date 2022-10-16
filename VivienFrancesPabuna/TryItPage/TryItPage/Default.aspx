<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Part4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 id="TitleLabel">#1 WebDownloading</h1>
        <p class="lead">The pre-selected link for our vending machine system's use-case has been entered below.<br />However, for demo purposes, you may also enter your own website instead.</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="min-width: 800px" Rows="10" TextMode="MultiLine">https://innercircle.engineering.asu.edu/</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SortButton" runat="server" OnClick="Button2_Click" Text="Download" />
        </p>
        <p>
            &nbsp;</p>
        <p>&nbsp;<asp:TextBox ID="ResultLabel" runat="server" BackColor="#D7D7D7" OnTextChanged="TextBox2_TextChanged" ReadOnly="True" style="min-width: 800px" Rows="10" TextMode="MultiLine"></asp:TextBox>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
