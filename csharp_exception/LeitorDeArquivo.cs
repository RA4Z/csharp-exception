namespace csharp_exception;

public class LeitorDeArquivo //: IDisposable
{
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
        try
        {
            Arquivo = arquivo;
        }
        catch (FileNotFoundException)
        {
            throw new FileNotFoundException();
        }

        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }

    public string LerProximaLinha()
    {
        try
        {
            Console.WriteLine("Lendo linha. . .");
        }
        catch (IOException)
        {
            throw new IOException();
        }

        return "Linha do arquivo";
    }

    public void Fechar()
    {
        Console.WriteLine("Fechando arquivo.");
    }
}