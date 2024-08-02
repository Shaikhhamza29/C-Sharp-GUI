<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vowels.aspx.cs" Inherits="Vowels.Vowels" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Vowels or Consonant"></asp:Label>
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Enter a Character"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Result" />
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
