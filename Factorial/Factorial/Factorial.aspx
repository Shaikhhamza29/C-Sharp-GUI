﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Factorial.aspx.cs" Inherits="Factorial.Factorial" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Factorial Of Number"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter the Number : "></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="FactResult" 
        Text="Result " />
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Width="290px"></asp:TextBox>
    </form>
</body>
</html>
