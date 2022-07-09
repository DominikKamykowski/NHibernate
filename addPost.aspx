<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPost.aspx.cs" Inherits="kolokwium_.addPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Type" runat="server" Text="Typ ogłoszenia:"></asp:Label>
            <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList>
        </div>
          <div>
            <asp:Label ID="lblDate" runat="server" Text="Data wygaśnięcia:"></asp:Label>
              <asp:Calendar ID="calDate" runat="server"></asp:Calendar>
<%--              <asp:CustomValidator ID="DataValidator" runat="server" ControlToValidate="calDate" ErrorMessage="Zbyt krotka data!" OnServerValidate="DataValidator_ServerValidate"></asp:CustomValidator>--%>
        </div>
        <div>
            <asp:Label ID="lblTopic" runat="server" Text="Tytuł:"></asp:Label>
            <asp:TextBox ID="txtTopic" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="LenghtValidator" ControlToValidate="txtTopic" MaximumValue="300" runat="server" ErrorMessage="Zbyt dlugi tytuł!"></asp:RangeValidator>

        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text="Opis:"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="OpisValidator" ControlToValidate="txtDescription" MaximumValue="3000" runat="server" ErrorMessage="Zbyt dlugi opis!"></asp:RangeValidator>

        </div>
        <div>
            <asp:Label ID="lblPremium" runat="server" Text="Ogłoszenie premium:"></asp:Label>
            <asp:CheckBox ID="chckPremium" runat="server" Text="Premium" OnCheckedChanged="chckPremium_CheckedChanged"/>
            <asp:Label ID="lblWhenPremium" runat="server" Text="Ogłoszenie premium jest płatne! Cena: 10zł"></asp:Label>

        </div>
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Dodaj" OnClick="btnAdd_Click" />
        </div>
        </form>
</body>
</html>
