<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     
    
    <form id="form1" runat="server">
       <asp:Button 
           ID="Button2" 
            runat="server" 
            Text="Second Button" 
            OnClick="button1_Click"
            Font-Bold="true"
            ForeColor="DodgerBlue"
            Height="45"
            Width="150"
            />
    </form>
</body>
</html>
