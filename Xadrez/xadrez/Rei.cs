using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;
namespace Xadrez.xadrez {
    class Rei:Peca {

        private PartidaDeXadrez partida;

        public Rei(tabuleiro tab, Cor cor, PartidaDeXadrez partida):base(tab, cor)
        {
            this.partida = partida;
        }

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.qteMovimentos == 0;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.linhas, Tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.linha - 1, Posicao.coluna);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha + 1, Posicao.coluna-1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha, Posicao.coluna-1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(Posicao.linha - 1, Posicao.coluna-1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            // ROQUE PEQUENO
            pos.definirValores(Posicao.linha - 1, Posicao.coluna);
            if(qteMovimentos==0 && !partida.xeque)
            {
                Posicao posT1 = new Posicao(Posicao.linha, Posicao.coluna + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna + 2);
                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna + 2] = true;
                    }
                }
            }

            // ROQUE Grande
            pos.definirValores(Posicao.linha - 2, Posicao.coluna);
            if (qteMovimentos == 0 && !partida.xeque)
            {
                Posicao posT2 = new Posicao(Posicao.linha, Posicao.coluna - 4);
                if (testeTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna - 2);
                    Posicao p3 = new Posicao(Posicao.linha, Posicao.coluna - 3);
                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna - 2] = true;
                    }
                }
            }

            return mat;








        }
    }
}
