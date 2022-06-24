namespace HotelCsharp.Models
{
    public class Cliente : Pesssoa
    {
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void Apresentacao()
        {

        }
    }
}