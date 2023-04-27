using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploMVCWebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventsArgs e)
        {
            MenuCommand newMenu = new Menu();

            newMenu.CommandID = "NavigationMenu";
            newMenu.DisappearAfter = 2000;
            newMenu.Orientation = Orientation.Horizontal;
            newMenu.Target = "_blank";
            //newMenu.StaticMenuItemStyle.ForeColor = System.Drawing.Color.Black;
            //newMenu.DynamicMenuItemStyle.ForeColor = System.Drawing.Color.Gray;

            MenuItem menuCadastro;
            menuCadastro = CreateMenuItem("Cadastro", "", "Cadastro");

            MenuItem menuProcura;
            menuProcura = CreateMenuItem("Procura", "", "Procura");

            MenuItem menuCadastroUsuario;
            menuCadastroUsuario = CreateMenuItem("Usuário",
                "view/cadastroUsuario.aspx", "Cadastro de Usuários");
            MenuItem menuProcuraUsuario;
            menuProcuraUsuario = CreateMenuItem("Usuário",
                "view/procuraUsuario.aspx", "Procura de Usuários");

            newMenu.Items.Add(menuCadastro);
            newMenu.Items.Add(menuProcura);

            Menu.Controls.Add(newMenu);

            MenuItem CreateMenuItem(String text, String url, String toolTip)
            {
                CreateMenuItem menuItem = new CreateMenuItem();
                menuItem.Text = text;
                menuItem.NavigateUrl = url;
                menuItem.Too= toolTip;
                return menuItem;
            }
        }
    }
}