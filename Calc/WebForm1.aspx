<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="result" runat="server">0</asp:TextBox>
    
    </div>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button_Click" style="width: 21px" Text="1" />
            <asp:Button ID="Button3" runat="server" OnClick="Button_Click" Text="2" />
            <asp:Button ID="Button4" runat="server" OnClick="Button_Click" Text="3" />
            <asp:Button ID="Button14" runat="server" OnClick="Operator_Click" Text="+" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button_Click" Text="4" />
            <asp:Button ID="Button6" runat="server" OnClick="Button_Click" Text="5" />
            <asp:Button ID="Button7" runat="server" OnClick="Button_Click" Text="6" />
            <asp:Button ID="Button15" runat="server" OnClick="Operator_Click" Text="-" />
        </p>
        <p>
            <asp:Button ID="Button8" runat="server" OnClick="Button_Click" Text="7" />
            <asp:Button ID="Button9" runat="server" OnClick="Button_Click" Text="8" />
            <asp:Button ID="Button10" runat="server" OnClick="Button_Click" Text="9" />
            <asp:Button ID="Button16" runat="server" OnClick="Operator_Click" Text="*" />
        </p>
        <p>
            <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="C" />
            <asp:Button ID="Button12" runat="server" OnClick="Button_Click" Text="0" />
            <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="=" />
            <asp:Button ID="Button18" runat="server" OnClick="Button_Click" Text="," />
            <asp:Button ID="Button17" runat="server" OnClick="Button_Click" Text="/" />
        </p>
    </form>
</body>
</html>
