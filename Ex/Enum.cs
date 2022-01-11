enum Cor 
{
    Vermelho,
    Verde, 
    Amarelo
}

enum Alinhamento: sbyte
{
    Esquerda = -1,
    Centro = 0,
    Direita = 1
}

public class Exemplos
{
    static void EscreverCor(Cor cor)
    {
        switch(cor)
        {
            case Cor.Vermelho:
             Console.WriteLine("Vermelho");
             break;
            case Cor.Verde:
             Console.WriteLine("Verda");
             break;
            case Cor.Amarelo:
             Console.WriteLine("Amarelo");
             break;  
        }
    }

    static void Alinhar(Alinhamento alinhamento)
    {
      

    }


}