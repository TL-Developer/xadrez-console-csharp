using System;
using tabuleiro;
using tabuleiro.Enums;
using xadrez;

namespace xadrez_console_csharp
{
  class Tela
  {
    public static void ImprimirTabuleiro(Tabuleiro tab)
    {

      for (int i = 0; i < tab.linhas; i++)
      {
        Console.Write(8 - i + " ");
        for (int j = 0; j < tab.colunas; j++)
        {
          ImprimirPeca(tab.ObterPeca(i, j));
        }
        Console.WriteLine();
      }
      Console.WriteLine("  a b c d e f g h");
    }

    public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
    {
      ConsoleColor fundoOriginal = Console.BackgroundColor;
      ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

      for (int i = 0; i < tab.linhas; i++)
      {
        Console.Write(8 - i + " ");
        for (int j = 0; j < tab.colunas; j++)
        {
          if (posicoesPossiveis[i, j])
          {
            Console.BackgroundColor = fundoAlterado;
          }
          else
          {
            Console.BackgroundColor = fundoOriginal;
          }
          ImprimirPeca(tab.ObterPeca(i, j));
          Console.BackgroundColor = fundoOriginal;
        }
        Console.WriteLine();
      }
      Console.WriteLine("  a b c d e f g h");
      Console.BackgroundColor = fundoAlterado;
    }

    public static PosicaoXadrez LerPosicaoXadrez()
    {
      string s = Console.ReadLine();
      char coluna = s[0];
      int linha = int.Parse(s[1] + "");

      return new PosicaoXadrez(coluna, linha);
    }

    public static void ImprimirPeca(Peca peca)
    {

      if (peca == null)
      {
        Console.Write("- ");
      }
      else
      {
        if (peca.cor == Cor.Branca)
        {
          Console.Write(peca);
        }
        else
        {
          ConsoleColor aux = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.Write(peca);
          Console.ForegroundColor = aux;
        }
        Console.Write(" ");
      }
    }
  }
}
