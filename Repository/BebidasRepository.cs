using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Models.Bebidas;

namespace PizzariaCSharp.Repository
{
    public class BebidasRepository
    {
        private List<Bebida> _bebidas;
        private int _ultimoId = 0;

        public BebidasRepository() 
        {
            _bebidas = new List<Bebida>();
        }

        public Bebida Adiciona(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;
            _bebidas.Add(bebida);
            return bebida;
        }
        public List<Bebida>ObterTodos()
        {
            return _bebidas;
        }
        public Bebida Obter(int id)
        {
            return _bebidas
            .Where(b=> b.Id == id)
            .FirstOrDefault();
        }

        public Bebida Atualizar (Bebida bebida)
        {
            var bebidaEncontrada = _bebidas.Where(b=> b.Id == bebida.Id).FirstOrDefault();

            if(bebidaEncontrada == null)
            {
                throw new Exception ("não é possível atualizar uma bebida que não existe");
            }
            _bebidas.Remove(bebidaEncontrada);
            _bebidas.Add(bebida);
            return bebida;
        }
        public void Deletar (int id)
        {
            var bebida = Obter(id);
            if(bebida == null)
            {
                throw new Exception("não é possível deletar uma bebida que não existe");
            }
            _bebidas.Remove(bebida);
        }
    }
}