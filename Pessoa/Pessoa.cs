using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Pessoa.Pessoa
{
	public class Pessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }

		public Pessoa(int id, string nome, int idade)
		{
			Id = id;
			Nome = nome;
			Idade = idade;
		}
		
		public override string ToString()
		{
			return $"Id: {Id}, Nome: {Nome}, Idade: {Idade}";
		}
	}
}
