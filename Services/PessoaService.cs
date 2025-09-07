using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CRUD_Pessoa.Models; // adiciona para importar PessoaModel

namespace CRUD_Pessoa.Services
{
	public class PessoaService
	{
		private List<PessoaModel> pessoas = new List<PessoaModel>();
		private int proximoId = 1;

				public void CriarPessoa(string nome, int idade)
		{
			PessoaModel p = new PessoaModel(proximoId, nome, idade);
			pessoas.Add(p);
			proximoId++;
			Console.WriteLine("Pessoa criada com sucesso!");
		}

		public List<PessoaModel> ListarPessoa()
		{
			return pessoas;
		}

		public void AtualizarPessoa(int id, string nome, int idade)
		{
			PessoaModel p = pessoas.Find(p => p.Id == id);
			if (p != null)
			{
				p.Nome = nome;
				p.Idade = idade;
				Console.WriteLine("Pessoa atualizada com sucesso!");
			}
			else
			{
				Console.WriteLine("Pessoa não encontrada!");
			}
		}

		public void DeletarPessoa(int id)
		{
			PessoaModel p = pessoas.Find(p => p.Id == id);
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
}