<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Página de Consulta</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
                <nav class="navbar navbar-light bg-light">
                    <span class="navbar-brand mb-0 h1">Consulta de Pessoas</span>
                </nav>
                <div class="row">

                    <asp:GridView ID="gridPessoa" runat="server" CssClass="table table-hover table-striped table-bordered" GridLines="None" AutoGenerateColumns="false" BackColor="White">
                        <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Código"/>
                            <asp:BoundField DataField="nome" HeaderText="Nome"/>
                            <asp:BoundField DataField="endereco" HeaderText="Endereço"/>
                            <asp:BoundField DataField="email" HeaderText="E-mail"/>
                        </Columns>
                        <RowStyle CssClass="cursor-pointer"/>
                    </asp:GridView>
                    

                    <p>
                        <asp:Label ID="lblMensagem" runat="server"/> 
                    </p>
                    
                    <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                </div>
            
        </div>
    </form>
</body>
</html>
