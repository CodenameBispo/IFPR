using ExemploMVCWebForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploMVCWebForms.controller
{
    public class TipoUsuarioController
    {
        private List<TipoUsuario> tipoUsuarios;
        public TipoUsuarioController()
        {
            tipoUsuarios = new List<TipoUsuario>();
            TipoUsuario tipoUsuarioAdm = new TipoUsuario();
            tipoUsuarioAdm.Id = 1;
            tipoUsuarioAdm.Descricao = "Administrador";
            TipoUsuario tipoUsuarioFunc = new TipoUsuario();
            tipoUsuarioFunc.Id = 2;
            tipoUsuarioFunc.Descricao = "Funcionário";
            tipoUsuarios.Add(tipoUsuarioAdm);
            tipoUsuarios.Add(tipoUsuarioFunc);
        }
        public List<TipoUsuario> findAll()
        {
            return tipoUsuarios;
        }
    }
}