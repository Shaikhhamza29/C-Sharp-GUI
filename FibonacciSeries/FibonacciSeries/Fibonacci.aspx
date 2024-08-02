<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fibonacci.aspx.cs" Inherits="FibonacciSeries.Fibonacci" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label runat="server" Text="Fibonacci Series"></asp:Label>
    
    </div>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Enter The Limit"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Fibonacci_Series" Text="Result" />
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    </form>
</body>
</html>
