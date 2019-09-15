using System;
using tabuleiro;
using tabuleiro.Enums;
using xadrez;

namespace xadrez_console_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(1, 5));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
