using System;
					
public class Exercicio2
{
	public static void Main()
	{
		float F;
		float C;
				
		Console.WriteLine("Bem vindo!");
		
		Console.WriteLine("Digite a temperatura em Fahreinheit: ");
		F = float.Parse(Console.ReadLine());
		
		C = ((F - 32) * 5) / 9;
		
		Console.WriteLine("Conversão da temperatura para graus Celsius é de: " + C);
	}
}