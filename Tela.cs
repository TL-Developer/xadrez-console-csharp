using System;
using tabuleiro;

namespace xadrez_console_csharp
{
    class Tela
    {

      public static void ImprimirTabuleiro(Tabuleiro tab)
      {

        for (int i = 0; i < tab.linhas; i++)
        {
          for (int j = 0; j < tab.colunas; j++)
          {
            if (tab.ObterPeca(i, j) == null)
            {
              System.Console.Write("- ");
            }
            System.Console.Write(tab.ObterPeca(i, j) + " ");
          }
          System.Console.WriteLine();
        }
      }

    }
}
