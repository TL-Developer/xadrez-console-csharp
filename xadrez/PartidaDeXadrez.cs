using tabuleiro;
using tabuleiro.Enums;
using System;

namespace xadrez
{
  class PartidaDeXadrez {

    public Tabuleiro tabuleiro {get; private set; }
    private int turno;
    private Cor jogadorAtual;
    public bool terminada { get; set; }

    public PartidaDeXadrez()
    {
      tabuleiro = new Tabuleiro(8, 8);
      turno = 1;
      jogadorAtual = Cor.Branca;
      terminada = false;
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
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('a', 8).ToPosicao());
      tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('b', 8).ToPosicao());
      tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('g', 8).ToPosicao());
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('c', 8).ToPosicao());
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('h', 8).ToPosicao());

      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('a', 1).ToPosicao());
      tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('b', 1).ToPosicao());
      tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('g', 1).ToPosicao());
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 1).ToPosicao());
      tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('h', 1).ToPosicao());
    }

  }
}
