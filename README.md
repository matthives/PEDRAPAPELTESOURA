# Projeto

O projeto foi feito em C# durante as aulas do curso Back-End da [Academia do Programador](https://www.academiadoprogramador.net) 2026 

## Introdução

Especificação
Neste projeto, desenvolvemos o clássico jogo Pedra, Papel, Tesoura em console utilizando C#.

O objetivo é permitir que um jogador dispute contra o computador em múltiplas rodadas, com regras simples e bem definidas.

Sobre o Sistema

- Jogador: escolhe entre Pedra, Papel ou Tesoura através do console
- Computador: realiza uma escolha aleatória
= Resultado: o sistema compara as escolhas e determina o vencedor

Regras do jogo:

1. Pedra vence Tesoura
2. Tesoura vence Papel
3. Papel vence Pedra
4. Escolhas iguais resultam em empate

## Como utilizar o programa

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

    ```
    dotnet restore  
    ```
4. Para executar o projeto compilando em tempo real

    ```
    dotnet run --project PedraPapelTesoura.ConsoleApp
    ```

## Requisitos

.NET 10.0 SDK