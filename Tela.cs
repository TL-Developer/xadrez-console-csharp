using System;
using tabuleiro;
using tabuleiro.Enums;

namespace xadrez_console_csharp
{
    class Tela
    {

      public static void ImprimirTabuleiro(Tabuleiro tab)
      {

        for (int i = 0; i < tab.linhas; i++)
        {
          System.Console.Write(8 - i + " ");
          for (int j = 0; j < tab.colunas; j++)
          {
            if (tab.ObterPeca(i, j) == null)
            {
              System.Console.Write("- ");
            }
            else
            {
              ImprimirPeca(tab.ObterPeca(i, j));
              System.Console.Write(" ");
            }
          }
          System.Console.WriteLine();
        }
        System.Console.WriteLine("  a b c d e f g h");
      }

      public static void ImprimirPeca(Peca peca)
      {
        if (peca.cor == Cor.Branca)
        {
          System.Console.Write(peca);
        }
        else
        {
          ConsoleColor aux = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Yellow;
          System.Console.Write(peca);
          Console.ForegroundColor = aux;
        }
      }

    }
}
