using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Models.Bebidas;
using PizzariaCSharp.Models.Cliente;
using PizzariaCSharp.Models.Pizzas;

namespace PizzariaCSharp.Models.Pedido
{
    public class Pedido
    {
        public int Id {get; private set;}
        public DateTime DataEHora {get; private set;}
        public Clientes cliente {get; private set;}
        public List<Pizza> Pizza  {get; private set;}
        public List<Bebida> Bebidas  {get; private set;}
        
        
        
    }
}