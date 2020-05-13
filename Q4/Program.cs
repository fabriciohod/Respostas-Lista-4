using System;
namespace Q4
{
    public class Program
    {
        static void Main (string[] args)
        {
            int[, ] matriz = { { 31, 78, 90 }, { 85, 97, 40 }, { 123, 7, 90 } };
            Console.WriteLine (PegarNumeroAleatorio (matriz));
        }
        static int PegarNumeroAleatorio (int[, ] matriz)
        {
            Random rnd = new Random ();
            int linha = rnd.Next (0, matriz.GetLength (0) - 1);
            int coluna = rnd.Next (0, matriz.GetLength (1) - 1);
            return matriz[linha, coluna];
        }
    }
}