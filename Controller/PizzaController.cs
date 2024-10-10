using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Models.Pizzas;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PizzaController: ICrudController<Pizza>
    {
        private ICrudRepository<Pizza> _repositoryPizza;

        public PizzaController(ICrudRepository<Pizza> repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public Pizza Adicionar(Pizza modelo)
        {
            return _repositoryPizza.Adicionar(modelo);
        }

        public Pizza Atualizar(int id, Pizza modelo)
        {
            modelo.Id =id;
            return _repositoryPizza.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _repositoryPizza.Deletar(id);
        }

        public Pizza Obter(int id)
        {
            return _repositoryPizza.Obter(id);
        }

        public List<Pizza> ObterTodos()
        {
           return _repositoryPizza.ObterTodos();
        }
    }
}