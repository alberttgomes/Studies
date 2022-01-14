namespace ExemploClasseAbstrata
{
    public abstract class Conta
    {
       protected double saldo {set; get; }

       public abstract void Creditar(double valor);
       
       public void ExibirSaldo()
       {
           System.Console.WriteLine($"Seu saldo é: {saldo}");
       }
    }

    public class ContaCorrente : Conta
    {
        private double tarifa {get; set; }

        public override void Creditar(double valor)
        {
            this.saldo = valor;
        }
    }

    // C L A S S E    S E L A D A
    //
    public class Pessoa2
    {
        public string? nome;
        public int idade;

        public virtual void Apresentar()
        {
            System.Console.WriteLine("");
        }
    }

    public class Aluno2: Pessoa2
    {
        public double nota;

        public override void Apresentar()
        {
           System.Console.WriteLine($"Meu nome é {nome}. Minha nota foi {nota}");
        }
    }

    public sealed class Professor2: Pessoa2
    {
        public double salario {get; set; }

        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {nome}, sou professor. Meu salário é {salario}");

        }
    }

}