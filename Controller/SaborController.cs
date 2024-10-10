using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Models.Sabores;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class SaborController: ICrudController<Sabor>
    {
        private ICrudRepository<Sabor> _repositorySabor;

        public SaborController(ICrudRepository<Sabor> repositorySabor)
        {
            _repositorySabor = repositorySabor;
        }

        public Sabor Adicionar(Sabor modelo)
        {
            return _repositorySabor.Adicionar(modelo);
        }

        public Sabor Atualizar(int id, Sabor modelo)
        {
            modelo.Id = id;
            return _repositorySabor.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _repositorySabor.Deletar(id);
        }

        public Sabor Obter(int id)
        {
            return _repositorySabor.Obter(id);
        }

        public List<Sabor> ObterTodos()
        {
            return _repositorySabor.ObterTodos();
        }
    }
}