<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Raamen.View.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Update Ramen List"></asp:Label><br /><br />


            <asp:Label ID="Label2" runat="server" Text="Meat ID"></asp:Label><br />
            <asp:TextBox ID="meatTxt" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label3" runat="server" Text="Ramen"></asp:Label><br />
            <asp:TextBox ID="ramenTxt" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label4" runat="server" Text="Broth"></asp:Label><br />
            <asp:TextBox ID="brothTxt" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label><br />
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />

        </div>
    </form>
</body>
</html>
