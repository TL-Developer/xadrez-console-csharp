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

      public void ColocarPeca(Peca peca, Posicao posicao)
      {
        this.pecas[posicao.linha, posicao.coluna] = peca;
        peca.posicao = posicao;
      }
    }
}
