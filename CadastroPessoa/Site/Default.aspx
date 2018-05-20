<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <script src="../Scripts/jquery-1.9.1.min.js" ></script>
    <script src="../Scripts/bootstrap.min.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto CRUD - Gerenciamento de Pessoas</h1>

            Selecione uma operação desejada: 
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text=" - Escolha uma opção - "/>
                <asp:ListItem Value="1" Text="Cadastrar"/>
                <asp:ListItem Value="2" Text="Todas as Pessoas"/>
                <asp:ListItem Value="3" Text="Atualizar ou Excluir"/>
            </asp:DropDownList>
            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnAcessar"/>

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
