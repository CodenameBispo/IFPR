using ExemploMVCWebForms.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExemploMVCWebForms.dao
{
    public class UsuarioDao
    {
        private Conexao conexao = new Conexao();;

        public void Create(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "Insert into Usuario VALUES(@nome, @cpf, @idTipoUsuario)";

            command.Parameters.AddWithValue("@nome", usuario.nome);
            command.Parameters.AddWithValue("@cpf", usuario.Cpf);
            command.Parameters.AddWithValue("@idTipoUsuario", usuario.TipoUsuario.id);

            command.ExecuteNonQuery();  
        }
    }

    public List<Usuario> findAll()
    {
        SqlCommand command = new SqlCommand();
        command.Connection = Conexao.Connection;
        command.CommandText = "SELECT id, nome, cpf, idTipoUsuario FROM Usuario";

        SqlDataReader reader = command.ExecuteReader();
        List<Usuario> usuarios = new List<Usuario>();

        while (reader.Read())
        {
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(reader[0]);
            usuario.Nome = Convert.ToString(reader[1]);
            usuario.Cpf = Convert.ToString(reader[2]);
            usuario.TipoUsuario.Id = Convert.ToInt32(reader[3]);
            usuarios.Add(usuario);
        }
        return usuarios;
    }
}