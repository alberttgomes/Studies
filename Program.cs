// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExemploClasseAbstrata;
using ExemploCalculadora;
using ExemploHeranca;
using ExemploRetangulo;
using Exemplo_Interface;

namespace StudiesDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // E X E M P L O   C A L C U L A D O R A
            //
            // P O L I M O R F I S M O   C O M P I L A Ç Ã O

            // Calculadora calculadora = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calculadora.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calculadora.Somar(15,15,30));
            
            ICalculadora calc = new CalculadoraComum();
            System.Console.WriteLine(calc.somar(10,15));
            System.Console.WriteLine(calc.dividir(10,15));
            System.Console.WriteLine(calc.multiplicar(10,15));
            System.Console.WriteLine(calc.subtrair(15, 10));
           
            // E X E M P L O  S T R E A M   L I S T

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            
            //    E X E M P L O   P I L H A
            //
            //   var s = new Pilha();

            //   s.Stack(1);
            //   s.Stack(10);
            //   s.Stack(100);
            //   s.Stack(1000);
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());

            //   s.Stack(1000);
            //   s.Stack(100);
            //   s.Stack(10);
            //   s.Stack(1);
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());
            //   Console.WriteLine(s.Unstacks());
            
            //    E X E M P L O   R E T A N G U L O
            //
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // Console.WriteLine($"Área: {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);

            // Console.WriteLine($"Área: {r2.ObterArea()}");
            
            //    E X E M P L O   H E R A N Ç A S 
            //
            Aluno aluno = new Aluno();
            aluno.nota = 10.0;
            aluno.nome = "Albert";
            aluno.idade = 26;
            aluno.documento = "000.222.000-22";
            
            aluno.Apresentar();

            Professor professor = new Professor();
            professor.salario = 7.000;
            professor.nome = "Diego";
            professor.idade = 45;
            professor.documento = "111.000.111-00";

            professor.Apresentar();
            
            //  E X E M P L O   C L A S S   A B S T R A C T
            //
            ContaCorrente corrente = new ContaCorrente();
            corrente.Creditar(100000);

            corrente.ExibirSaldo();
        
        
        
        }

    }

}