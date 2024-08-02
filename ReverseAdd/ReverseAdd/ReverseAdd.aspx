<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReverseAdd.aspx.cs" Inherits="ReverseAdd.ReverseAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Reverse And Sum Of The Digit"></asp:Label>
        <br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Enter the Number"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Reverse"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Sum"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    </form>
</body>
</html>
