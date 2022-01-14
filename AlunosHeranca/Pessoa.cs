namespace  ExemploHeranca
{
    public class Pessoa
    {
        public string? nome {get; set; }
        public int idade {get; set; }
        public string? documento {get; set; }

        public virtual void Apresentar()
        {
           System.Console.WriteLine($"Olá meu nome é {nome}, tenho {idade} identificação {documento}");
        }

    }

    public class Aluno: Pessoa
    {
        public double nota {get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {nome}. Nota em programação orientada a objetos é {nota}");
        }
    }

    public class Professor: Pessoa
    {
        public double salario {get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {nome}. Sou professor e o meu salário é {salario}");
        }
    }
}