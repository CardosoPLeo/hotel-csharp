namespace HotelCsharp.Exceptions.DocumentosInvalidosException
{
    public class DocumentosInvalidosException : Exception
    {
        public DocumentosInvalidosException()
        :base("Documentos Inválidos, verifique")
        {

        }

        public DocumentosInvalidosException(string mensagem) : base(mensagem)
        {

        }
    }

}