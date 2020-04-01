using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //[HttpGet] como o nome do método ja é Get (post, put, delete) não preciso colocar uma definição do qual tipo de chamada 
        //Exemplo:
            //[HttpGet]
            //public List<Cliente> Pegar()
            //{

            //}
        public List<Cliente> Get()
            {
            return clientes;
        }

        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
             clientes.Add(new Cliente(nome));
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
