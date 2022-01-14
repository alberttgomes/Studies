// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;
using AlunoEx;
using AlunoEnum;

namespace Alunos
 {
     class Program
     {
         static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota: ");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                           aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser décimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} -  Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;
                        
                        for(int i = 0; i < alunos.Length; i++)
                        {
                          if(!string.IsNullOrEmpty(alunos[i].Nome))
                          {
                              notaTotal = notaTotal + alunos[i].Nota;
                              numAlunos++;

                          }   
                        }

                        var mediaGeral = notaTotal / numAlunos;
                        AlunoConceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = AlunoConceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = AlunoConceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = AlunoConceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = AlunoConceito.B;
                        }
                        else
                        {
                            conceitoGeral = AlunoConceito.A;
                        }

                        Console.WriteLine($"Média geral: {mediaGeral} - Conceito: {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            
            opcaoUsuario = ObterOpcaoUsuario();
        
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcaoUsuario = "";
            return opcaoUsuario;
        }
    }
 }