<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="content-type" content= "text/html; charset=utf-8" />
    <title></title>    
</head>
<body>
    <form id="formProcura" runat="server">
        <div>
            <table>
                <tr><td>
                    <asp:Label ID="labelNome" runat="server" Text="Nome: "></asp:Label>
                </td><td>
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </td></tr>
                <tr><td>
                    <asp:Label ID="labelCpf" runat="server" Text="CPF"></asp:Label>
                 </td><td>
                    <asp:TextBox ID="cpf" runat="server"></asp:TextBox>
                </td></tr>
                <tr><td>                    
                    <asp:Button ID="buttonProcurar" runat="server" Text="Procurar" 
                        OnClick="buttonProcurar_Click" />
                </td><td>
                    <asp:Button ID="buttonFechar" runat="server" Text="Fechar" />
                </td>
                </tr>
            </table>
        </div>
            <asp:Table ID="tableProcura" runat="server" GridLines="Both">
                <asp:TableHeaderRow runat="server" Font-Bold="true">
                    <asp:TableHeaderCell>Id</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Nome</asp:TableHeaderCell>
                    <asp:TableHeaderCell>CPF</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Tipo Usuario</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        <div>
        </div>
    </form>
</body>
</html>
