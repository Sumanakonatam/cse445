<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemStorage.aspx.cs" Inherits="Part4._ItemStorage" ValidateRequest="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 id="TitleLabel">ItemStorage</h1>
        <h5 >Service description goes here.</h5>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="min-width: 800px" Rows="1" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SortButton" runat="server" OnClick="Button2_Click" Text="Go" />
        </p>
        <p>&nbsp;<asp:TextBox ID="ResultLabel" runat="server" BackColor="#D7D7D7" OnTextChanged="TextBox2_TextChanged" ReadOnly="True" style="min-width: 800px" Rows="10" TextMode="MultiLine"></asp:TextBox>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
