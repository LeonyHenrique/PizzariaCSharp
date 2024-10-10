using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Models.Cliente;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Clientes>
    {
        private ICrudRepository<Clientes> _repositoryCliente;

        public ClienteController(ICrudRepository<Clientes> repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
        public Clientes Adicionar(Clientes modelo)
        {
            return _repositoryCliente.Adicionar(modelo);
        }

        public Clientes Atualizar(int id, Clientes modelo)
        {
            modelo.Id = id;
            return _repositoryCliente.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _repositoryCliente.Deletar(id);
        }

        public Clientes Obter(int id)
        {
            return _repositoryCliente.Obter(id);
        }

        public List<Clientes> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}