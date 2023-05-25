using ExemploMVCWebForms.dao;
using ExemploMVCWebForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVCWebForms.controller
{
    public class UsuarioController : Controller
    {
        public void delete(int id)
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            usuarioDao.delete(id);
        }

        public void create(Usuario usuario)
        {
            //Usuario usuario = new Usuario();
            UsuarioDao usuarioDao = new UsuarioDao();     
            usuarioDao.Create(usuario);
        }

        public Usuario findById(int id)
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            return usuarioDao.findById(id);
        }

        public List<Usuario> findByNomeOuCpf(String nome, String cpf)
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            return usuarioDao.findByNomeOuCpf(nome, cpf);
        }

        public List<Usuario> findAll()
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            return usuarioDao.findAll();
        }

        public void update(Usuario usuario)
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            usuarioDao.update(usuario);
        }
    }
}