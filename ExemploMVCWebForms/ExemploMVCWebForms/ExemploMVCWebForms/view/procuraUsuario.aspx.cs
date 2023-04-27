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
	public partial class procuraUsuario : System.Web.UI.Page
	{
		List<Usuario> usuarios;
		UsuarioController usuarioController;
		protected void Page_Load(object sender, EventArgs e)
		{
			usuarios = new List<Usuario>();
			usuarioController = new UsuarioController();
			usuarios = usuarioController.findAll();
			listarUsuarios();
		}

		protected void buttonProcurar_Click(object sender, EventArgs e)
		{
			usuarios = new List<Usuario>();
			usuarioController = new UsuarioController();
			usuarios = usuarioController.findAll();
		}

		private void listarUsuarios()
		{
			foreach (procuraUsuario usuario in usuarios)
			{
				TableCell id = new TableCell();
				TableCell nome = new TableCell();
				TableCell cpf = new TableCell();
				TableCell tipoUsuario = new TableCell();

				id.Text = Convert.ToString(usuario.Id);
				nome.Text = nome.ID;
				cpf.Text = usuario.Cpf;
				tipoUsuario.Text = Convert.ToString(usuario.TipoUsuario.Id);

				TableRow linha = new TableRow();
				linha.Cells.Add(id);
				linha.Cells.Add(nome);
				linha.Cells.Add(cpf);
				linha.Cells.Add(tipoUsuario);

				tableProcura.Rows.Add(linha);

			}
		}
	}
}