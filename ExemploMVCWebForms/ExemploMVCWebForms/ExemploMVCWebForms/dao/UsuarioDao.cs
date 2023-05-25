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
        private Conexao conexao = new Conexao();
        public void delete(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "Delete From Usuario where id = @id";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public void Create(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "Insert into Usuario VALUES(@nome, @cpf, @idTipoUsuario)";

            command.Parameters.AddWithValue("@nome", usuario.Nome);
            command.Parameters.AddWithValue("@cpf", usuario.Cpf);
            command.Parameters.AddWithValue("@idTipoUsuario", usuario.TipoUsuario.Id);

            command.ExecuteNonQuery();
        }

        public Usuario findById(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "Select id, nome, cpf, idTipoUsuario FROM Usuario" +
                "where id = @id";
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();
            Usuario usuario = new Usuario();

            while (reader.Read())
            {
                usuario.Id = Convert.ToInt32(reader[0]);
                usuario.Nome = Convert.ToString(reader[1]);
                usuario.Cpf = Convert.ToString(reader[2]);
                usuario.TipoUsuario.Id = Convert.ToInt32(reader[3]);
            }
            return usuario;
        }

        public List<Usuario> findByNomeOuCpf(String nome, String cpf)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "SELECT id, nome, cpf, idTipoUsuario FROM Usuario";

            if (nome != "" && cpf != "")
            {
                command.CommandText = command.CommandText +
                    " where nome like '%" + nome + "%' " +
                    " and cpf like '%" + cpf + "%' ";
            }
            else if (nome != "")
            {
                command.CommandText = command.CommandText +
                    " where nome like '%" + nome + "%' ";
            }
            else if (cpf != "")
            {
                command.CommandText = command.CommandText +
                    " where cpf like '%" + cpf + "%' ";
            }

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


        public List<Usuario> findAll()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
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

        public void update(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.Connection;
            command.CommandText = "Update Usuario set cpf = '" + usuario.Cpf + "'," +
                " nome = '" + usuario.Nome + "', " +
                " idTipoUsuario = " + usuario.TipoUsuario.Id +
                " where id = " + usuario.Id;

            command.ExecuteNonQuery();
        }
    }
}