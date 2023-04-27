<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroUsuario.aspx.cs" Inherits="ExemploMVCWebForms.view.cadastroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Usuários</title>
</head>
<body>
    Cadastro de Usuários
    <form id="formCadastroUsuario" runat="server">
        <div>
            <table>
                <tr><td>
                    <asp:Label ID="labelId" runat="server" Text="Id: "> </asp:Label>
                </td><td>
                    <asp:HiddenField ID="id" runat="server" />
                </td></tr>
                <tr><td>
                    <asp:Label ID="labelNome" runat="server" Text="Nome: "></asp:Label>
                </td><td>
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </td></tr>
                <tr><td>
                    <asp:Label ID="labelCpf" runat="server" Text="CPF: "></asp:Label>
                </td><td>
                    <asp:TextBox ID="cpf" runat="server"></asp:TextBox>
                </td></tr>
                <tr><td>
                    <asp:Label ID="labelTipoUsuario" runat="server" Text="Tipo Usuario: "></asp:Label>
                </td><td>
                    <asp:DropDownList ID="tipoUsuario" runat="server"></asp:DropDownList>
                </td></tr>
                <tr><td>
                    <asp:Button ID="cadastrar" runat="server" Text="Cadastrar" OnClick="cadastrar_Click" />
                </td></tr>
            </table>
        </div>
    </form>
</body>
</html>
