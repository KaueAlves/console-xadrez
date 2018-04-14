using System;
using tabuleiro;

namespace Xadrex_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Tabuleiro tab = new Tabuleiro(8,8);
        
        Tela.imprimirTabuleiro(tab);
        }
    }
}