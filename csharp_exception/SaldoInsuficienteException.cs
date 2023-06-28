namespace csharp_exception;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensagem) : base(mensagem)
    {

    }
}
