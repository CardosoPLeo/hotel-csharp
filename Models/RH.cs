using HotelCsharp.Interfaces;
using HotelCsharp.Exceptions.DocumentosInvalidosException;
namespace HotelCsharp.Models
{
    public class RH : IRHTerceirizado
    {
        public string Nome { get; set; }
        public Hotel Hotel { get; set; }

        public RH(string nome, Hotel hotel)
        {
            Nome = nome;
            Hotel = hotel;
        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Hotel.Camareiras.Add(camareira);
        }

        public void ContratarGerente(IGerente gerente)
        {
            Hotel.ContratarGerente(gerente);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel.Recepcionistas.Add(recepcionista);
        }

        public void PromoverParaGerente(Camareira camareira)
        {
            if (camareira.CPF == null)
            {
                throw new DocumentosInvalidosException("Está faltando o CPF ser cadastrado para a promoção");
            }
            Hotel.ContratarGerente(new Gerente()
            {
                Nome = camareira.Nome,
                CPF = camareira.CPF,
                Telefone = camareira.Telefone
            });
        }

        public void PromoverParaGerente(Recepcionista recepcionista)
        {
            if (recepcionista.CPF ==  null)
            {
                throw new DocumentosInvalidosException("Está faltando o CPF ser cadastrado para a promoção");
            }
            Hotel.ContratarGerente(new Gerente()
            {
                Nome = recepcionista.Nome,
                CPF = recepcionista.CPF,
                Telefone = recepcionista.Telefone
            });
        }
    }
}