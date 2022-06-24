using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Camareira : Pesssoa, ICamareira
    {
        public Camareira()
        {
        }

        public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Prazer sou a camareira {Nome}");
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
    }
}