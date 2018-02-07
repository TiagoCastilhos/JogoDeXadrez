using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.xadrez;
namespace Xadrez.Tabuleiro {
    abstract class Peca {

        public Posicao Posicao;
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public tabuleiro Tabuleiro { get; protected set; }


        public Peca(tabuleiro Tabuleiro, Cor Cor)
        {
            Posicao = null;
            this.Tabuleiro = Tabuleiro;
            this.Cor = Cor;
            qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public abstract bool[,] movimentosPossiveis();
        
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tabuleiro.linhas; i++)
            {
                for(int j = 0; j < Tabuleiro.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
    }
}
