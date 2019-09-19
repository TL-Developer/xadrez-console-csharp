using tabuleiro;
using tabuleiro.Enums;

namespace xadrez
{
    class Rei : Peca
    {

      public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
      {}

      public override string ToString()
      {
        return "R";
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
        if(tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // ne
        posicao.DefinirValores(posicao.linha - 1, posicao.coluna + 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // direita
        posicao.DefinirValores(posicao.linha, posicao.coluna + 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // se
        posicao.DefinirValores(posicao.linha + 1, posicao.coluna + 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // abaixo
        posicao.DefinirValores(posicao.linha + 1, posicao.coluna);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // so
        posicao.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // acima
        posicao.DefinirValores(posicao.linha, posicao.coluna - 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }
        // no
        posicao.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
        if (tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
          mat[posicao.linha, posicao.coluna] = true;
        }

        return mat;
      }
    }
}
