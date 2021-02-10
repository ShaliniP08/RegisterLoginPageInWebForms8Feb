<%@ Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppRegisterLogin8Feb.Default"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div style="margin-left: 120px">
            <br />
            <br />
            Welcome, Guest User!<br />
            <br />
            <br />
            <br />
            If you are a new user, click here to
            <asp:HyperLink ID="hyperRegister" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
            <br />
            <br />
            If already registered, click here to
            <asp:HyperLink ID="hyperLogin" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
        
        <br />
            <br />
            <br />
        
        
        </div>
   </asp:Content>