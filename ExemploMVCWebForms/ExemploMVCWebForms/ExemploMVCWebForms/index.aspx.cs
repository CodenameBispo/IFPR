using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploMVCWebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();

            newMenu.ID = "NavigationMenu";
            newMenu.DisappearAfter = 2000;
            newMenu.Orientation = Orientation.Horizontal;
            newMenu.Target = "_blank";
            //newMenu.StaticMenuItemStyle.ForeColor = System.Drawing.Color.Black;
            //newMenu.DinamicMenuItemStyle.ForeColor = System.Drawing.Color.Gray;

            MenuItem menuCadastro;
            menuCadastro = CreateMenuItem("Cadastro", "", "Cadastro");

            MenuItem menuProcura;
            menuProcura = CreateMenuItem("Procura", "", "Procura");

            MenuItem menuCadastroUsuario;
            menuCadastroUsuario = CreateMenuItem("Usu�rio", "view/cadastroUsuario.aspx", "Cadastro de Usu�rios");

            MenuItem menuProcuraUsuario;
            menuProcuraUsuario = CreateMenuItem("Usu�rio", "view/procuraUsuario.aspx", "Procura de Usu�rios");

            menuCadastro.ChildItems.Add(menuCadastroUsuario);
            menuProcura.ChildItems.Add(menuProcuraUsuario);

            newMenu.Items.Add(menuCadastro);
            newMenu.Items.Add(menuProcura);

            Menu.Controls.Add(newMenu);

        }
        MenuItem CreateMenuItem(String text, String url, String toolTip)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.Text = text;
            menuItem.NavigateUrl = url;
            menuItem.ToolTip = toolTip;
            return menuItem;
        }

    }
}