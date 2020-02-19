using System;
					
public class Exercicio1
{
	public static void Main()
	{
		float velocidadeMedia;
		float tempo;
		float distancia;
		float litros;
		
		Console.WriteLine("Seja bem vindo!");
		Console.WriteLine("Veiculo com média de 12km por litro");
		
		Console.WriteLine("Digite o tempo gasto para percorrear a sua viagem em HORAS: ");
		tempo = float.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite a velocidade média do veiculo em KM/H: ");
		velocidadeMedia = float.Parse(Console.ReadLine());
		
		distancia = tempo * velocidadeMedia;
		
		litros = distancia / 12;
		
		Console.WriteLine("Velocidade média do veiculo: " + velocidadeMedia);
		Console.WriteLine("Tempo gasto de viagem: " + tempo);
		Console.WriteLine("A distancia percorrida é de: " + distancia);
		Console.WriteLine("Quantidade de litros utilizados pelo veiculo: " + litros);
	}
}