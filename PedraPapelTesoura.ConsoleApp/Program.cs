using System.Reflection;
using System.Security.Cryptography;

const int ESCOLHA_PEDRA = 1;
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

while (true)
{
    // Input de escolha do Jogador
    int escolhaJogador;

    do // vai executar pelo menos uma vez
    {
        Console.Clear();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Pedra, Papel, Tesoura");
        Console.WriteLine("--------------------------");
        Console.WriteLine("1 - Tesoura");
        Console.WriteLine("2 - Tesoura");
        Console.WriteLine("3 - Tesoura");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Digite uma opção válida: ");
        string? strEscolhaJogador = Console.ReadLine();

        Console.WriteLine("-----------------------------");

        if (strEscolhaJogador == "1" || strEscolhaJogador == "2" || strEscolhaJogador == "3")
        {
            escolhaJogador = Convert.ToInt32(strEscolhaJogador);
            break;
        }
    } while (true);

    // 2. escolha aleatória do computador
    int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);

    // 3. Comparação dos valores
    if (escolhaJogador == escolhaComputador)
    {
        Console.WriteLine("Empate!");
    }
    else if (escolhaJogador == ESCOLHA_PEDRA)
    {
        Console.Write("Pedra vs ");

        if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("O Computador Venceu.");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você Venceu.");
        }
    }
    else if (escolhaJogador == ESCOLHA_PAPEL)
    {
        Console.Write("Papel vs ");

        if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você Venceu.");
        }
        else if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("Você venceu.");
        }
    }
    else if (escolhaJogador == ESCOLHA_TESOURA)
    {
        Console.Write("Tesoura vs ");

        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("O computador venceu.");
        }
        else if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("Você venceu.");
        }
    }

    Console.WriteLine("-----------------------------");

    Console.Write("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine()?.ToUpper();

    if (opcaoContinuar != "S")
        break;

}