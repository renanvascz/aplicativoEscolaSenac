using System;
using System.Collections.Generic; // Referência à lista

namespace escola;

public class Professor
{
    public string? nome;
    public string? dataNascimento;
    protected string? bairro;
    protected string? estado;
    protected string? pais;
    private string? login;
    private string? senha;

    public Professor CadastrarProfessor()
    {
        Console.WriteLine("Digite o nome do Professor: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento: ");
        dataNascimento = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o bairro: ");
        bairro = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o estado: ");
        estado = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o País: ");
        pais = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o login: ");
        login = Console.ReadLine() ?? "";
        Console.WriteLine("Digite a senha: ");
        senha = Console.ReadLine() ?? ""; 
        return this; // Retorna o próprio objeto
    }

    public bool Login(List<Professor> listaProfessores)
    {
        int tentativas = 3;

        do
        {
            Console.WriteLine("========TELA DE LOGIN========");
            Console.WriteLine("Digite seu Login: ");
            string? loginAtual = Console.ReadLine();
            Console.WriteLine("Digite sua Senha: ");
            string? senhaAtual = Console.ReadLine();

            foreach (var professor in listaProfessores)
            {
                if (loginAtual == professor.login && senhaAtual == professor.senha)
                {
                    Console.WriteLine("Login Realizado com Sucesso"); 
                    return true;             
                }
            }
            tentativas--;

            Console.WriteLine("Login/Senha incorretos");
            Console.WriteLine($"Você ainda tem {tentativas} tentativas");

        } while (tentativas > 0); // Condição corrigida

        return false;        
    }
}
