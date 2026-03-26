using System.Security.Cryptography;

bool jogoDeveContinuar = true;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("-----  Jogo de Adivinhação  -----");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("-Escolha o nível de dificuldade:-");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("--  1 - Fácil (10 tentativas)  --");
    Console.WriteLine("--  2 - Médio (5 tentativas)   --");
    Console.WriteLine("--  3 - Dificil (3 tentativas) --");

    Console.WriteLine("------ Digite sua escolha: ------");
    string dificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio = 0;
    int tentativasMaximas;

    switch (dificuldadeEscolhida)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break;

        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Por favor, selecione uma difiuldade válida.");
            Console.WriteLine("------  Digite ENTER para continuar.  ------");
            Console.ReadLine();
            continue;
    }

    int pontuacao = 1000;

    int[] numerosDigitados = new int[tentativasMaximas];
    int contadorNumeroDigitados = 0;

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("------ Jogo de Adivinhação ------");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"------ Tentativa {tentativaAtual} de {tentativasMaximas}. --------");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("------- Digite um número: -------");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;

        for (int indiceAtual = 0; indiceAtual < numerosDigitados.Length; indiceAtual++)
        {
            if (numerosDigitados[indiceAtual] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("O burro tu já digitou esse número, digita outro.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("--------- Digite ENTER para continuar ----------");
            Console.ReadLine();
            tentativaAtual--;

            continue;
        }

        if (contadorNumeroDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumeroDigitados] = numeroDigitado;
            contadorNumeroDigitados++;
        }

        else
        {
            numerosDigitados = new int[tentativasMaximas];
            contadorNumeroDigitados++;

            numerosDigitados[contadorNumeroDigitados] = numeroDigitado;
            contadorNumeroDigitados++;
        }

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Boa mula acertou na cagada!");
            Console.WriteLine("------- O numero era: " + numeroAleatorio + "------");
            Console.WriteLine("---------------------------");
            break;
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
        Console.WriteLine("-- Digite ENTER para continuar --");
        Console.ReadLine();

        if (tentativaAtual == tentativasMaximas)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Perdeu marreco kkkkk tenta de novo na proxima.");
            Console.WriteLine("----------------------------------------------");
        }

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }

        else if (diferencaNumerica >= 5)
        {
            pontuacao -= 50;
        }

        else
        {
            pontuacao -= 20;
        }

        Console.WriteLine("---------------------");
        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.WriteLine("---------------------");

        Console.WriteLine("-- Digite ENTER para continuar --");
        Console.ReadLine();
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (S/N)");
    string opcaoContinuar = Console.ReadLine().ToUpper();

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}