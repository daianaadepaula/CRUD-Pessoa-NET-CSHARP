using CRUD_Pessoa.Pessoa;

class Program
{
	static List<Pessoa> pessoas = new List<Pessoa>();
	static int proximoId = 1;

	static void Main(string[] args)
	{
		bool executar = true;

		while (executar)
		{
			Console.WriteLine("Escolha uma opção: ");
			Console.WriteLine("1 - Criar");
			Console.WriteLine("2 - Listar");
			Console.WriteLine("3 - Atualizar");
			Console.WriteLine("4 - Deletar");
			Console.WriteLine("0 - Sair");

			string opcao = Console.ReadLine();

			switch (opcao)
			{
				case "1":
					CriarPessoa();
					break;
				case "2":
					ListarPessoa();
					break;
				case "3":
					AtualizarPessoa();
					break;
				case "4":
					DeletarPessoa();
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

	// 
	static void CriarPessoa()
	{
		Console.WriteLine("Digite o nome: ");
		string nome = Console.ReadLine();

		Console.WriteLine("Digite a idade: ");
		int idade = int.Parse(Console.ReadLine());

		Pessoa p = new Pessoa(proximoId, nome, idade);
		pessoas.Add(p);
		proximoId++;

		Console.WriteLine("Pessoa criada com sucesso!");
	}

	static void ListarPessoa()
	{ 
		Console.WriteLine("Lista de pessoas:");
		foreach (Pessoa p in pessoas)
		{
			Console.WriteLine(p.ToString());
		}
	}

	static void AtualizarPessoa()
	{
		Console.WriteLine("Digite o ID da pessoa a ser atualizada: ");
		int id = int.Parse(Console.ReadLine());

		Pessoa p = pessoas.Find(p => p.Id == id);

		if (p != null)
		{
			Console.WriteLine("Digite o novo nome: ");
			string nome = Console.ReadLine();

			Console.WriteLine("Digite a nova idade: ");
			int idade = int.Parse(Console.ReadLine());

			p.Nome = nome;
			p.Idade = idade;

			Console.WriteLine("Pessoa atualizada com sucesso!");
		}
		else
		{
			Console.WriteLine("Pessoa não encontrada!");
		}
	}

	static void DeletarPessoa()
	{
		Console.WriteLine("Digite o ID da pessoa a ser deletada: ");
		int id = int.Parse(Console.ReadLine());

		Pessoa p = pessoas.Find(p => p.Id == id);
		
		if (p != null)
		{
			pessoas.Remove(p);
			Console.WriteLine("Pessoa deletada com sucesso!");
		}
		else
		{
			Console.WriteLine("Pessoa não encontrada!");
		}		
	}
}