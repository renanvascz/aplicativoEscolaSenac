using System;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic; // Adicionei a referência para a lista funcionar

namespace escola;

public class Program
{
    static void Main()
    {
        float nota1, nota2, nota3, media;
        string opcao; 
        bool estaLogado = false; 

        List<Professor> listaProfessores = new List<Professor>();
        Professor professorAtual = new Professor();
        
        int opcaoMenu; 
        Console.WriteLine("======== Menu ========");
        Console.WriteLine("1° Cadastrar Professor");
        Console.WriteLine("2° Fazer Login");
        Console.WriteLine("3° Calcular Média do Aluno"); 
        Console.WriteLine("4° Fechar o programa");
        Console.WriteLine("Digite uma das opções acima: ");
        opcaoMenu = int.Parse(Console.ReadLine() ?? "");

        switch (opcaoMenu)
        {
            case 1:
                professorAtual = professorAtual.CadastrarProfessor();
                listaProfessores.Add(professorAtual); 
                break;
            case 2:
                estaLogado = professorAtual.Login(listaProfessores);
                break;
            case 3:
                Console.WriteLine("Opção 3 não está disponível neste momento.");
                break;
            case 4:
                Console.WriteLine("Programa encerrado.");
                return;
            default:
                Console.WriteLine("Digite um número entre 1 e 4, de acordo com a opção do menu desejada: ");
                return; 
        }

        if (estaLogado)
        {
            do
            {
                Console.WriteLine("Bem-Vindo Professor(a) " + professorAtual.nome);
                
                Console.WriteLine("Digite a nota 1 do aluno: ");
                nota1 = float.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Digite a nota 2 do aluno: ");
                nota2 = float.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Digite a nota 3 do aluno: ");
                nota3 = float.Parse(Console.ReadLine() ?? "");

                media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("A média do aluno é: " + media.ToString("F2"));

                if (media >= 7)
                {
                    Console.WriteLine("Você está APROVADO!");
                }
                else if (media < 7 && media >= 3)
                {
                    Console.WriteLine("Você está em RECUPERAÇÃO.");
                }
                else
                {
                    Console.WriteLine("Você está REPROVADO!");
                }

                Console.WriteLine("Deseja calcular a média de outro aluno?");
                Console.WriteLine("Digite 's' para sim e 'n' para não");
                opcao = Console.ReadLine() ?? "";
            } while (opcao == "s" || opcao == "S");
        }
        
        Console.WriteLine("Não pode acessar a área do aluno. Faça seu login novamente!");
    }
}
