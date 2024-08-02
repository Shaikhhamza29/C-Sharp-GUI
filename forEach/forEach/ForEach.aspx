<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForEach.aspx.cs" Inherits="forEach.ForEach" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Factorial using ForEach loop"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Loop" Text="Result" />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="54px" Width="347px"></asp:TextBox>
    </form>
</body>
</html>
