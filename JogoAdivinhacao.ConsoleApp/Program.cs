using System.Security.Cryptography;

Console.WriteLine("-------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("-------------------");

Console.WriteLine();
Console.WriteLine("Digite um número: ");
string strnumeroDigitado = Console.ReadLine();

int nuemroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("O número aleatório foi: " + nuemroAleatorio);

Console.ReadLine();
