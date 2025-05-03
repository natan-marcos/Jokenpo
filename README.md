# Jokenpo

Este é um projeto simples em C# que implementa o clássico jogo "Pedra, Papel e Tesoura" (Jokenpo). O jogador compete contra o computador, que faz escolhas aleatórias.

## Como jogar

1. Ao iniciar o programa, você verá as opções disponíveis:
   - `1` para Pedra
   - `2` para Papel
   - `3` para Tesoura
   - `0` para Sair do jogo
2. Digite o número correspondente à sua escolha e pressione Enter.
3. O programa exibirá a escolha do computador e o resultado da rodada:
   - **Empate**: Ambos escolheram a mesma jogada.
   - **Vitória**: Sua jogada vence a do computador.
   - **Derrota**: A jogada do computador vence a sua.
4. O jogo continuará até que você escolha a opção `0` para sair.

## Requisitos

- **.NET Framework 4.7.2**
- **C# 7.3**

## Como executar

1. Clone este repositório ou copie os arquivos do projeto.
2. Abra o projeto no Visual Studio 2022.
3. Compile e execute o programa pressionando `F5` ou clicando em __Iniciar__.

## Estrutura do código

- O programa utiliza um `enum` chamado `Mao` para representar as jogadas possíveis: Pedra, Papel e Tesoura.
- A lógica do jogo é implementada no método `Main`, que utiliza um loop para permitir múltiplas rodadas até que o jogador escolha sair.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.
