using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Models.Sabores;

namespace PizzariaCSharp.Models.Pizzas
{
    public class Pizza
      {
       public int Id {get; set;}
       public ETipoPizza TipoPizza {get; set;}
       public ETipoBorda TipoBorda  {get; set;}
       public double Valor {get; set;}
       public List<Sabor> Sabores {get; set;}

  public Pizza(
            ETipoPizza tipoPizza, 
            ETipoBorda tipoBorda, 
            double valor, 
            List<Sabor> sabores)
        {
            TipoPizza = tipoPizza;
            TipoBorda = tipoBorda;
            Valor = valor;
            Sabores = sabores;
        }
    }
}