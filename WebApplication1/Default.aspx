<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       
       
        <asp:Button ID="Button1" runat="server" Text="Clicca per mostrare il tuo nome" OnClick="Button1_Click"/>
        <p id="testParagrafo" runat="server"></p>
        

    </main>

</asp:Content>
