using ContactManagerMvc.Models; 
using ContactManagerMvc.Repositorio; 
using ContactManagerMvc.Data; 

namespace ContactManagerMvc.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel ListarPorId(int id); 
        bool Apagar(int id);
    }
}