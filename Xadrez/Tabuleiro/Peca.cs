using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro {
    class Peca {

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


    }
}
