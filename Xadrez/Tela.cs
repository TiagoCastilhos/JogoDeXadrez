using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;
using Xadrez.xadrez;
namespace Xadrez {
    class Tela {
        public static void imprimirTabuleiro (tabuleiro tab)
        {

            for (int i= 0;i< tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                { 
                       imprimirPeca(tab.peca(i, j));                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            
        }
        public static void imprimirPeca(Peca peca)
            {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirTabuleiro(tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor FundoOriginal = Console.BackgroundColor;
            ConsoleColor FundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                { 
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = FundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = FundoOriginal;

                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = FundoOriginal;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = FundoOriginal;
        }
    }
}
