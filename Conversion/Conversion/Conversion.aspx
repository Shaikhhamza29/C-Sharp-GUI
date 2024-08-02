<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="Conversion.Conversion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" submitdisabledcontrols="True">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Money  Conversion"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter the Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Money" Text="Conversion" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="INR to Dollar"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Height="37px" Width="340px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Dollar To INR"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" Height="36px" Width="350px"></asp:TextBox>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
