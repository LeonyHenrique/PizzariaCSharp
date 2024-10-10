using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Models.Cliente;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository: ICrudRepository<Clientes>
    {
        private List<Clientes> _clientes;
        private int _ultimoId = 0;

        public ClienteRepository()
        {
            _clientes = new List<Clientes>();
        }
        public Clientes Adicionar(Clientes modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _clientes.Add(modelo);

            return modelo;
        }

        public Clientes Atualizar(Clientes modelo)
        {
            var clienteEncontrada = _clientes.Where(b => b.Id == modelo.Id).FirstOrDefault();

            if(clienteEncontrada == null)
            {
                throw new Exception("Não é possível atualizar uma cliente que não exista.");
            }

            _clientes.Remove(clienteEncontrada);

            _clientes.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var cliente = Obter(id);

            if(cliente == null)
            {
                throw new Exception("Não foi encontrada uma cliente com o ID " + id);
            }

            _clientes.Remove(cliente);
        }

        public Clientes Obter(int id)
        {
            return _clientes
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public List<Clientes> ObterTodos()
        {
           return _clientes;
        }
    }
}