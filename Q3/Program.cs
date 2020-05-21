using System;
using System.Linq;
namespace Q3
{
    public class Program
    {
         public static string ContagemDeNumerosRepitidos (int[] array, int comparador)
        {
            int qtdDeRepetissoes = 0;
            foreach (var item in array)
            {
                if (item == comparador && array.GroupBy (x => x).Any (g => g.Count () > 1))
                {
                    qtdDeRepetissoes++;
                }
            }
            if (qtdDeRepetissoes == 0) return $"o numero {comparador} nao foi encontrado";
            return $"O numero {comparador} se repete {qtdDeRepetissoes}";
        }
    }
}
