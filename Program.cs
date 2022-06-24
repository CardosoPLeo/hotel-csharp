using HotelCsharp.Exceptions.DocumentosInvalidosException;
using HotelCsharp.Interfaces;
using HotelCsharp.Models;

Console.WriteLine("************************************************");
Console.WriteLine("*************** Hotel Csharp *******************");
Console.WriteLine("************************************************");
Console.WriteLine();

ICamareira camareira1 = new Camareira("Maria","12345678901","021999999999");
ICamareira camareira2 = new Camareira("Luiza","12345678902","021999999998");

IRecepcionista recepcionista1 = new Recepcionista("Joana","11111112233221","21988776655");
IRecepcionista recepcionista2 = new Recepcionista("Mariana","11111112238821","21988776644");

IGerente gerente1 = new Gerente()
{
    Nome = "José",
    CPF = "7273737273729",
    Telefone = "21978789999"
};

IGerente gerente2 = new Gerente()
{
    Nome = "Márcio",
    CPF = "727373727328",
    Telefone = "21978789988"
};


var hotel = new Hotel("Hotel CSharp", new Endereco()
{
    CEP = "25975-780",
    Rua = "Rua Ab",
    Numero = "100",
    Complemento = "Esquina A",
    Bairro = "Algum bairro",
    Cidade = "Rio de Janeiro",    
});

hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

hotel.ContratarGerente(gerente1);
hotel.ContratarCamareira(gerente2);
hotel.ContratarRecepcionista(gerente2);

hotel.Gerente.Apresentacao();
hotel.Gerente.ArrumarCama();
hotel.Gerente.AtenderTelefone();
hotel.Gerente.LimparQuarto();
hotel.Gerente.SaberInglesBasico();
hotel.Gerente.SabertudoSobreOHotel();


foreach (var camareira in hotel.Camareiras)
{
    camareira.Apresentacao();
    camareira.ArrumarCama();
    camareira.LimparQuarto();
    
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.Apresentacao();
    recepcionista.AtenderTelefone();
    recepcionista.SaberInglesBasico();
   
}

Console.WriteLine();

IRHTerceirizado rh = new RH("RH CSharp", hotel);

var camareira3 = new Camareira(){
    Nome = "Norma da Silva"
};

rh.ContratarCamareira(camareira3);

var recepcionista3 = new Recepcionista(){
    Nome = "Marisa da Silva"
};

rh.ContratarRecepcionista(recepcionista3);

var camareiaASerPromovida = new Camareira
{
    Nome = "Maria Silveira"
};

try
{
    rh.PromoverParaGerente(camareiaASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
     System.Console.WriteLine(ex.Message);
}

var recepcionsitaASerPromovida = new Recepcionista
{
    Nome = "Maria Silveira",
    CPF = "01234567890"
};

try
{
    rh.PromoverParaGerente(recepcionsitaASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
     System.Console.WriteLine(ex.Message);
}


Console.WriteLine();