namespace ContactManagerMvc.Models
{

    public class ContatoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public ContatoModel() { }

        public ContatoModel(string nome, string email, string celular)
        {
            Nome = nome;
            Email = email;
            Celular = celular;
        }
    }
}