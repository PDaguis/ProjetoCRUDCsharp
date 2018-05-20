<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
                <nav class="navbar navbar-light bg-light">
                     <span class="navbar-brand mb-0 h1">Detalhes de Pessoas</span>
                </nav>
                <br />
            
                <div class="form-group">
                    <label for="txtCodigo">Digite o código: </label>
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="10%"></asp:TextBox><br />
                    <asp:Button ID="btnPesquisa" runat="server" CssClass="btn btn-info" Text="Pesquisar" OnClick="BtnPesquisar"/>
                    <a href="/Default.aspx" class="btn btn-light btn-md">Voltar</a>
                </div>
                
                <asp:Panel ID="pnlDados" runat="server">
                <label for="txtNome">Nome: </label>
                <div class="form-group">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="50%"></asp:TextBox><br />
                </div>
                
                <label for="txtEndereco">Endereço</label>
                <div class="form-group">
                    <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" Width="50%"></asp:TextBox><br />
                </div>
                
                <label for="txtEmail">E-mail</label>
                <div class="form-group">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="50%"></asp:TextBox>
                </div>

               
               
                <asp:Button ID="btnAtualizar" runat="server" CssClass="btn btn-success" Text="Atualizar" OnClick="BtnAtualiza"/>
                <asp:Button ID="btnExcluir" runat="server" CssClass="btn btn-danger" Text="Excluir" OnClick="BtnExclui"/>
                
                </asp:Panel>
             <p>
                <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"/>
             </p>
            </div>
    </form>
</body>
</html>
