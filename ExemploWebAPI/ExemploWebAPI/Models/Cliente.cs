using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string _nome)
        {
            this.Nome = _nome;
        }
    }
}