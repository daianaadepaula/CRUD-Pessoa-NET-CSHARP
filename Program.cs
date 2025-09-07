using CRUD_Pessoa.Models;
using CRUD_Pessoa.Services;

class Program
{
    static void Main(string[] args)
    {
        PessoaService service = new PessoaService();
        bool executar = true;

        while (executar)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Criar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("0 - Sair");
						Console.WriteLine("------------------------------");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CriarPessoa(service);
                    break;
                case "2":
                    ListarPessoa(service);
                    break;
                case "3":
                    AtualizarPessoa(service);
                    break;
                case "4":
                    DeletarPessoa(service);
                    break;
                case "0":
                    executar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CriarPessoa(PessoaService service)
    {
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida!");
            return;
        }

        service.CriarPessoa(nome, idade);
    }

    static void ListarPessoa(PessoaService service)
    {
        var pessoas = service.ListarPessoa();

        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        Console.WriteLine("\nLista de pessoas: ");
        foreach (PessoaModel p in pessoas)
        {
            Console.WriteLine(p);
        }
    }

    static void AtualizarPessoa(PessoaService service)
    {
        Console.WriteLine("Digite o ID da pessoa a ser atualizada: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o novo nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a nova idade: ");
        int idade = int.Parse(Console.ReadLine());

        service.AtualizarPessoa(id, nome, idade);
    }

    static void DeletarPessoa(PessoaService service)
    {
        Console.WriteLine("Digite o ID da pessoa a ser deletada: ");
        int id = int.Parse(Console.ReadLine());

        service.DeletarPessoa(id);
    }
}
