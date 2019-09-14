namespace tabuleiro
{
    class Tabuleiro
    {
      public int linhas { get; set; }
      public int colunas { get; set; }
      private Peca[,] pecas;


      public Tabuleiro(int linhas, int colunas)
      {
        this.linhas = linhas;
        this.colunas = colunas;
        this.pecas = new Peca[linhas, colunas];
      }

      public Peca ObterPeca(int linha, int coluna)
      {
        return this.pecas[linha, coluna];
      }

      public Peca ObterPeca(Posicao posicao)
      {
        return this.pecas[posicao.linha, posicao.coluna];
      }

      public void ColocarPeca(Peca peca, Posicao posicao)
      {
        this.pecas[posicao.linha, posicao.coluna] = peca;
        peca.posicao = posicao;
      }

      public bool ExistePecao(Posicao posicao)
      {
        ValidaPosicao(posicao);
        return ObterPeca(posicao) != null;
      }

      public bool PosicaoValida(Posicao posicao)
      {
        if (posicao.linha < 0 || posicao.linha >= this.linhas || posicao.coluna < 0 || posicao.coluna >= this.colunas) {
          return false;
        }

        return true;
      }

      public void ValidaPosicao(Posicao posicao)
      {
        if(!PosicaoValida(posicao))
        {
          throw new TabuleiroException("Posição inválida!");
        }
      }
    }
}
