namespace Exemplo_Interface
{
    public interface ICalculadora
    {
       int somar (int num, int num1);
       int subtrair(int num, int num1);
       int multiplicar(int num, int num1);
       int dividir(int num, int num1);
       
    }

    public class CalculadoraComum : ICalculadora
    {
        public int dividir(int num, int num1)
        {
            return num / num1;
        }

        public int multiplicar(int num, int num1)
        {
            return num * num1;
        }

        public int somar(int num, int num1)
        {
            return num + num1;
        }

        public int subtrair(int num, int num1)
        {
            return num - num1;
        }
    }
}