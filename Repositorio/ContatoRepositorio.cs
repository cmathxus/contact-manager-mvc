using ContactManagerMvc.Models;
using ContactManagerMvc.Repositorio;
using ContactManagerMvc.Data;

namespace ContactManagerMvc.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public bool Apagar(int id)
        {
            ContatoModel contato = ListarPorId(id);
            if (contato == null) throw new Exception("Erro ao apagar o contato");

            _bancoContext.Contatos.Remove(contato);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}