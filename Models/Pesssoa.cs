using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public abstract class Pesssoa : IPessoa
    {
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        
        public Pesssoa()
        {

        }
        public Pesssoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public virtual void Apresentacao()
        {
            Console.WriteLine($"Praazer, meu nome é {Nome}");
            Console.WriteLine();
        }
    }
}