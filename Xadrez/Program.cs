using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args)
        {
            try
            {
                tabuleiro tabuleiro = new tabuleiro(8, 8);

                // Peças Pretas
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 4));
                tabuleiro.colocarPeca(new Dama(tabuleiro, Cor.Preta), new Posicao(0, 3));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0, 2));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0, 5));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0, 1));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0, 6));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 0));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 1));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 2));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 4));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 5));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 6));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, 7));

                //Peças Brancas
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 7));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 4));
                tabuleiro.colocarPeca(new Dama(tabuleiro, Cor.Branca), new Posicao(7, 3));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(7, 2));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(7, 5));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(7, 1));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(7, 6));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 0));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 1));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 2));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 3));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 4));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 5));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 6));
                tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(6, 7));



                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
