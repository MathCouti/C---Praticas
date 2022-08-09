using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string comando = "";
		int contador = 0;
		Console.WriteLine("Criar novo membro da familia?");
		comando = Console.ReadLine();
		while(comando == "s")
		{
			contador++;
			Console.Clear();
			Pessoa pessoa1 = new Pessoa();
			Console.WriteLine("Nome: ");
			pessoa1.Nome = Console.ReadLine();
			Console.WriteLine("Posição na familia: ");
			pessoa1.Posicao = Console.ReadLine();
			Console.WriteLine("Idade: ");
			pessoa1.Idade = int.Parse(Console.ReadLine());
			
			Lista.adicionar(pessoa1);
			
			Console.WriteLine("Adicionar mais um membro?");
			comando = Console.ReadLine();
			if(comando == "n")
			{
				Lista.exibir(pessoa1);		
			}
		}
			
		
	}
}

public class Pessoa
{
	public string Nome {get; set;}
	public string Posicao {get; set;}
	public int Idade {get; set;}
}

public class Lista
{
	static public List<Pessoa> familia = new List<Pessoa>();
	
	
	static public void adicionar(Pessoa pessoa1)
	{
		familia.Add(pessoa1);
	}
	static public void exibir(Pessoa pessoa1)
	{
		foreach(Pessoa exib in familia)
		{
			Console.WriteLine("Nome: {0}", exib.Nome);
			Console.WriteLine("Cargo na familia: {0}", exib.Posicao);
			Console.WriteLine("Idade: {0}\r\n", exib.Idade);
		}
		
	
	}
}
