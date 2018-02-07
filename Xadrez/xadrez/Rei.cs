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

            return mat;








        }
    }
}
