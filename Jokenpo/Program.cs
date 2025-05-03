using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    class Program
    {
        enum mao { Pedra = 1, Papel = 2, Tesoura = 3 }

        static void Main(string[] args)
        {
            Random random = new Random();

            int opcao = -1;
            while (opcao != 0)
            {
                // Lendo a escolha do usuário
                Console.WriteLine("=== Bem-vindo ao Jokenpo! ===");
                Console.WriteLine("Escolha sua jogada:");
                Console.WriteLine("1 - Pedra");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Tesoura");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite sua opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
                    continue;
                }

                if (opcao == 0)
                {
                    Console.WriteLine("Obrigado por jogar! Até a próxima.");
                    return;
                }

                // Converte para o tipo mao
                mao maoJogador = (mao)opcao;
                mao maoPc = (mao)random.Next(1, 4);

                // Exibe as escolhas
                Console.WriteLine($"\nVocê escolheu: {maoJogador}");
                Console.WriteLine($"O computador escolheu: {maoPc}\n");

                // Determina o resultado
                if (maoJogador == maoPc)
                {
                    Console.WriteLine("Resultado: Empate!\n");
                }
                else if ((maoJogador == mao.Pedra && maoPc == mao.Tesoura) ||
                         (maoJogador == mao.Papel && maoPc == mao.Pedra) ||
                         (maoJogador == mao.Tesoura && maoPc == mao.Papel))
                {
                    Console.WriteLine("Resultado: Parabéns, você ganhou!\n");
                }
                else
                {
                    Console.WriteLine("Resultado: Que pena, você perdeu!\n");
                }

                Console.WriteLine("=================================\n");
            }
        }
    }
}
