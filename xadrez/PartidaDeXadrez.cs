using tabuleiro;
using tabuleiro.Enums;
using System;

namespace xadrez
{
  class PartidaDeXadrez {

    public Tabuleiro tabuleiro {get; private set; }
    private int turno;
    private Cor jogadorAtual;

    public PartidaDeXadrez()
    {
      tabuleiro = new Tabuleiro(8, 8);
      turno = 1;
      jogadorAtual = Cor.Branca;
      ColocarPecas();
    }

    public void ExecutaMovimento(Posicao origem, Posicao destino)
    {
      Peca peca = tabuleiro.RetirarPeca(origem);
      peca.IncrementarQtdMovimentos();
      Peca pecaCapturada = tabuleiro.RetirarPeca(destino);
      tabuleiro.ColocarPeca(peca, destino);
    }

    private void ColocarPecas()
    {
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 1).ToPosicao());
    }

  }
}
