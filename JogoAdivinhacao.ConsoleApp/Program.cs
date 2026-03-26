using System.Security.Cryptography;

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool jogoDeveContinuar = true;

while (true)
{
    Console.Clear();
    Console.WriteLine("-------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("-------------------");

    Console.WriteLine();
    Console.WriteLine("Digite um número: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

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

    Console.WriteLine();
    Console.Write("Deseja continuar? (S/N)");
    string opcaoContinuar = Console.ReadLine().ToUpper();

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}