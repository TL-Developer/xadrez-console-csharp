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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partida.tabuleiro);
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
