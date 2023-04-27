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
        public void Create(Usuario usuario)
        {
            Usuario usuario = new Usuario();
            UsuarioDao usuarioDao = new UsuarioDao();             
        }
        public List<Usuario> findAll()
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            return usuarioDao.findAll;
        }
    }
}