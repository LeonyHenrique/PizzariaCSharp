using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaCSharp.Models.Cliente
{
    public class Clientes
     {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public List<Endereco> Enderecos {get; set;}
    }
}