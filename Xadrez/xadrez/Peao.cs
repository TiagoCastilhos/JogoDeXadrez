﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez {
    class Peao:Peca {
        public Peao(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool existeInimigo (Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p.Cor != Cor;
        }
    }
}
