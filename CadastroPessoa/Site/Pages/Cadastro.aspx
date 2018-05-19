<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
                    <h1>Cadastro de Pessoa</h1>
                    <br />

                    <div class="form-group">
                    <label for="txtNome">Nome: </label>
                    <asp:TextBox ID="txtNome" runat="server" Width="50%" CssClass="form-control"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite um nome !" ForeColor="Red" />  
                    </div> 

                    <div class="form-group">
                    <label for="txtEndereco">Endereço: </label>
                    <asp:TextBox ID="txtEndereco" runat="server" Width="50%" CssClass="form-control"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="requiredEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Digite um endereço !" ForeColor="Red" />
                    </div>

                    <div class="form-group">
                    <label>Email: </label>
                    <asp:TextBox ID="txtEmail" runat="server" Width="50%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Digite um email !" ForeColor="Red" />
                    </div>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    
                    <asp:Button ID="btnCadastrar" runat="server" CssClass="btn btn-success btn-lg" Width="30%" Text="Cadastrar" OnClick="BtnCadastrarPessoa" />
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
                    
    </form>
</body>
</html>
