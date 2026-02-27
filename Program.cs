using System;
using System.Reflection.Metadata.Ecma335;

namespace escola; //school;

public class Program
{
    static void Main()
    {
        // tipo nomeDaVariavel;
        float nota1, nota2, nota3, media;
        string opcao;     
        bool estaLogado = false;
        bool programaFinalizado = false;
        List <Professor> listaProfessores = new List<Professor>();
        Professor professorAtual = new Professor();
        
        do{
            int opcaoMenu;
            Console.WriteLine("======== MENU ========");
            Console.WriteLine("1 - Cadastrar Professor");
            Console.WriteLine("2 - Fazer Login");
            // Console.WriteLine("3 - Calcular Média do aluno");
            Console.WriteLine("3 - Fechar o Programa");
            Console.WriteLine("4 - Listar Professores");
            Console.WriteLine("Digite uma das opções acima: ");
            opcaoMenu = int.Parse(Console.ReadLine()?? "");

            switch (opcaoMenu)
            {
                case 1:
                    professorAtual = professorAtual.CadastrarProfessor(professorAtual);
                    listaProfessores.Add(professorAtual);
                    professorAtual = new Professor();
                    break;
                case 2:
                    estaLogado = professorAtual.Login(listaProfessores);
                    break;
                case 3:
                    estaLogado = false;
                    programaFinalizado = true;
                    break;

                //case 4:
                    //professorAtual.mostraListaProfessores(listaProfessores);
                    // break;
                default:
                    Console.WriteLine("Digite um número entre 1 e 3.");
                    break;
            }
        }while(estaLogado == false && programaFinalizado==false);


        if(estaLogado == true){
            do{
            
            Console.WriteLine("Bem-Vindo Professor(a) " + professorAtual.nome);
            
            Console.WriteLine("Digite a nota 1 do aluno: ");
            nota1 = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Digite a nota 2 do aluno: ");
            nota2 = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Digite a nota 3 do aluno: ");
            nota3 = float.Parse(Console.ReadLine() ?? "");

            media = (nota1+nota2+nota3)/3;

            Console.WriteLine("A média do aluno é: " + media.ToString("F2"));
            //Console.WriteLine($"A média do aluno é: {media}");
            //Se a media for maior ou igual a 7 = APROVADO, se a media for menor que 7 
            // e maior ou igual a 3 = RECUPERAÇÃO, menor que 3 = REPROVADO

            if (media >= 7)
            {
                Console.WriteLine("Você está APROVADO!");
            }

            else if (media < 7 && media>=3)
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
            }while(opcao=="s" || opcao=="S");
        }
        
        Console.WriteLine("Programa Finalizado.");
    }
}