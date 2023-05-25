using ExemploMVCWebForms.controller;
using ExemploMVCWebForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploMVCWebForms.view
{
    public partial class cadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.QueryString["id"] != null &&
                !string.IsNullOrEmpty(Page.Request.QueryString["id"]))
            {
                Usuario usuario = new Usuario();
                int idUsuario = Convert.ToInt32(Request.QueryString["id"]);
                UsuarioController usuarioController = new UsuarioController();
                usuario = usuarioController.findById(idUsuario);
                id.Text = Convert.ToString(usuario.Id);
                nome.Text = usuario.Nome;
                cpf.Text = usuario.Cpf;
                tipoUsuario.SelectedIndex = usuario.TipoUsuario.Id;
                cadastrar.Text = "Alterar";

                PropertyInfo isreadonly =
                typeof(System.Collections.Specialized.NameValueCollection).GetProperty(
                    "IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                isreadonly.SetValue(this.Request.QueryString, false, null);
                Request.QueryString["id"] = null;
                excluir.Enabled = true;
            }

            if (tipoUsuario.Items.Count == 0)
            {
                TipoUsuarioController tipoUsuarioController = new TipoUsuarioController();
                foreach (TipoUsuario tipo in tipoUsuarioController.findAll())
                {
                    tipoUsuario.Items.Insert(tipo.Id - 1, tipo.Descricao);
                }
            }
            
        }
        protected void cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nome.Text;
            usuario.Cpf = cpf.Text;
            usuario.TipoUsuario.Id = 1;
            UsuarioController usuarioController = new UsuarioController();
            
            if (id.Text == "")
            {
                usuarioController.create(usuario);
                LimparTela();
            }
            else
            {
                usuario.Id = Convert.ToInt32(id.Text);
                usuarioController.update(usuario);
                LimparTela();
            }
        }

        protected void excluir_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            if (id.Text != "")
            {
                int idUsuario = Convert.ToInt32(id.Text);
                usuarioController.delete(idUsuario);
                LimparTela();
            }
        }

        protected void LimparTela()
        {
            id.Text = "";
            nome.Text = "";
            cpf.Text = "";
            tipoUsuario.SelectedIndex = 0;
            cadastrar.Text = "Cadastrar";
            excluir.Enabled = false;
        }
    }
}