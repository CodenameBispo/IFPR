using ExemploMVCWebForms.controller;
using ExemploMVCWebForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploMVCWebForms.view
{
    public partial class cadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoUsuarioController tipoUsuarioController = new TipoUsuarioController();
            foreach (TipoUsuario tipo in tipoUsuarioController.findAll())
            {
                tipoUsuario.Items.Insert(tipo.Id - 1, tipo.Descricao);
            }
        }
        protected void cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nome.Text;
            usuario.Cpf = cpf.Text;
            usuario.TipoUsuario.Id = 1;
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.Create();
        }
    }
}