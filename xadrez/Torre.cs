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

      private bool PodeMover(Posicao posicao)
      {
        Peca peca = tabuleiro.ObterPeca(posicao);
        return peca == null || peca.cor != this.cor;
      }

      public override bool[,] MovimentosPossiveis()
      {
        bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

        Posicao posicao = new Posicao(0, 0);

        // acima
        posicao.DefinirValores(posicao.linha - 1, posicao.coluna);
        while (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;

          if (tabuleiro.ObterPeca(posicao) != null && tabuleiro.ObterPeca(posicao).cor != this.cor) {
            break;
          }

          posicao.linha = posicao.linha + 1;
        }

        // direita
        posicao.DefinirValores(posicao.linha, posicao.coluna + 1);
        while (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;

          if (tabuleiro.ObterPeca(posicao) != null && tabuleiro.ObterPeca(posicao).cor != this.cor)
          {
            break;
          }

          posicao.coluna = posicao.coluna + 1;
        }

        // esquerda
        posicao.DefinirValores(posicao.linha, posicao.coluna - 1);
        while (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;

          if (tabuleiro.ObterPeca(posicao) != null && tabuleiro.ObterPeca(posicao).cor != this.cor)
          {
            break;
          }

          posicao.coluna = posicao.coluna - 1;
        }

        return mat;
      }
    }
}
