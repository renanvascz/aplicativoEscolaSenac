using System.ComponentModel.Design;

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


    public Professor CadastrarProfessor(Professor professorCadastro)
    {
        Console.WriteLine("Digite o nome do Professor: ");
        professorCadastro.nome = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento: ");
        professorCadastro.dataNascimento = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o bairro: ");
        professorCadastro.bairro = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o estado: ");
        professorCadastro.estado= Console.ReadLine() ?? "";
        Console.WriteLine("Digite o País: ");
        professorCadastro.pais = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o login: ");
        professorCadastro.login = Console.ReadLine() ?? "";
        Console.WriteLine("Digite a senha: ");
        professorCadastro.senha = Console.ReadLine() ?? ""; 
        return professorCadastro;

    }

    public void mostraListaProfessores(List <Professor> listaProfessores)
    {
        int i = 1;
        foreach (var professor in listaProfessores)
        {
            Console.WriteLine($"Nome do professor {i}: {professor.nome}");
            Console.WriteLine($"Data de nascimento {i}: {professor.dataNascimento}");
            Console.WriteLine($"Login do professor{i}: {professor.login}");
            Console.WriteLine($"Senha do professor{i}: {professor.senha}");

            i++;
        }
    }

    public bool Login(List <Professor> listaProfessores)
    {
        int tentativas = 3;

        do{
            Console.WriteLine("======== TELA DE LOGIN ========");
            Console.WriteLine("Digite seu Login: ");
            string? loginAtual = Console.ReadLine();
            Console.WriteLine("Digite sua Senha: ");
            string? senhaAtual = Console.ReadLine();

            foreach (var professor in listaProfessores)
            {
                if(loginAtual==professor.login && senhaAtual == professor.senha)
                {
                    Console.WriteLine("Login Realizado com Sucesso"); 
                    return true;             
                }
            }
            tentativas = tentativas-1;

            Console.WriteLine("Login/Senha incorretos");
            Console.WriteLine($"Você ainda tem {tentativas} tentativas");

        }while(tentativas!=0);

        Console.WriteLine("Número de tentativas Excedido. Retornando ao menu...");

        return false;
        
    }


}
