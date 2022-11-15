<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Number2Words.aspx.cs" Inherits="Part4._Number2Words" ValidateRequest="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 id="TitleLabel1">#20 Number2Words</h1>
        <h5>Enter a number from 1 to 20, or enter 0 to see the directory.</h5>
        <br />
        <p>
            <asp:TextBox ID="NumberBox" runat="server" OnTextChanged="TextBox1_TextChanged" style="min-width: 800px" Rows="1" TextMode="MultiLine">0</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ConvertButton" runat="server" OnClick="ConvertButton_Click" Text="Convert" />
        </p>
        <p>&nbsp;<asp:TextBox ID="WordsBox" runat="server" BackColor="#D7D7D7" OnTextChanged="TextBox2_TextChanged" ReadOnly="True" style="min-width: 800px" Rows="25" TextMode="MultiLine"></asp:TextBox>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
