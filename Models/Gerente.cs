using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Gerente : Pesssoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Prazer, sou o gerente {Nome}");
            Console.WriteLine();
        }
        public void ArrumarCama()
        {
            Console.WriteLine("Sei arrumar a cama.");
            Console.WriteLine();

        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sei limpar o quarto.");
            Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sei atender Telefone");
            Console.WriteLine();
        }

        public void SaberInglesBasico()
        {
            Console.WriteLine("Sou fluente em inglês");
            Console.WriteLine();
        }

        public void SabertudoSobreOHotel()
        {
            Console.WriteLine("Sou o gerente e sei tudo sobre o hotel");
            Console.WriteLine();
        }
    }
}