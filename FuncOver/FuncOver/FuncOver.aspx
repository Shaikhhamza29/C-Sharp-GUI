<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FuncOver.aspx.cs" Inherits="FuncOver.FuncOver" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        Number of Integer is 2 and 5<br />
        <br />
        Number of Double is 3.0 and 5.0
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Result" 
            Text="Result " />
        <br />
        <br />
        Result: 
        <br />
        For Integer:</div>
    <asp:TextBox ID="TextBox3" runat="server" Height="83px" Width="248px"></asp:TextBox>
    <br />
    For Double:<br />
    <asp:TextBox ID="TextBox4" runat="server" Height="88px" Width="246px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
