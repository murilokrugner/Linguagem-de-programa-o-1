using System;

class MainClass {
  public static void Main (string[] args) {
    double R;
    double altura;
    double volume;

    Console.WriteLine("Bem vindo!");

    Console.WriteLine("Digite o Raio: ");
    R = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura: ");
    altura = double.Parse(Console.ReadLine());

    volume = 3.14159 * (R * R) * altura;

    Console.WriteLine("O volume é de: " + volume);
  }
}