using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez {
    class PartidaDeXadrez {

        public tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao Origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(Origem);
            p.incrementarQteMovimentos();
            Peca PecaCapturada = tab.RetirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            // Peças Pretas
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Dama(tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('f', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('g', 8).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('a', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('b', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('f', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('g', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('h', 7).toPosicao());

            //Peças Brancas
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Dama(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('f', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('g', 1).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('a', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('b', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('f', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('g', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('h', 2).toPosicao());



        }
    }
}
