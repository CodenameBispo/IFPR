using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploMVCWebForms.model
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string cpf;
        private TipoUsuario tipoUsuario;
        
        public Usuario()
        {
            tipoUsuario = new TipoUsuario();
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }
        public TipoUsuario TipoUsuario
        {
            get => tipoUsuario;
            set => tipoUsuario = value;
        }
    }
}