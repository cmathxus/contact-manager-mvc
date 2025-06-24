using ContactManagerMvc.Models; 
using ContactManagerMvc.Repositorio; 
using ContactManagerMvc.Data; 

namespace ContactManagerMvc.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}