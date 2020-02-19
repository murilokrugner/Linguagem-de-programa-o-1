using System;

namespace Exercicio4
{
	class Program {

		static void Main(string[] args)
		{
      int A;
      int B;
      int invert;

      Console.WriteLine("Bem vindo!");

      Console.WriteLine("Digite o valor de A: ");
      A = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor de B: ");
      B = Int32.Parse(Console.ReadLine());

      Console.WriteLine("O valor de A é: " + A);
      Console.WriteLine("O valor de B é: " + B);

      Console.WriteLine("Invertendo valores...");

      invert = A;
      A = B;
      B = invert;

      Console.WriteLine("Novo valor de A: " + A);
      Console.WriteLine("Novo valor de B: " + B);
		}
	}
}