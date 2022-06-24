using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Recepcionista : Pesssoa, IRecepcionista
    {
        public Recepcionista()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Olá sou a recepcionista {Nome}");
            Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sei atender Telefone");
            Console.WriteLine();
        }

        public void SaberInglesBasico()
        {
            Console.WriteLine("Sei falar o básico de inglês");
            Console.WriteLine();
        }
    }
}