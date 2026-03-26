using System.Security.Cryptography;

Console.WriteLine("-------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("-------------------");

Console.WriteLine();
Console.WriteLine("Digite um número: ");
string strnumeroDigitado = Console.ReadLine();

int numeroDigitado = Convert.ToInt32(Console.ReadLine());

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

if (numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Boa mula acertou na cagada!");
    Console.WriteLine("---------------------------");
}

else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("Errou animal. O número digitado é MAIOR que o número secreto.");
    Console.WriteLine("-------------------------------------------------------------");
}

else
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Ooo jegue, o número que tu digitou é MENOR que o número secreto.");
    Console.WriteLine("----------------------------------------------------------------");
}

Console.ReadLine();
