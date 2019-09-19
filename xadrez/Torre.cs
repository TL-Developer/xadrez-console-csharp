using tabuleiro;
using tabuleiro.Enums;

namespace xadrez
{
    class Torre : Peca
    {

      public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
      {
      }

      public override string ToString()
      {
        return "T";
      }

      public override bool[,] MovimentosPossiveis()
      {
        bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
        return mat;
      }
    }
}
