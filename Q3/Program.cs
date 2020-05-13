using System;
using System.Linq;
namespace Q3
{
    public class Program
    {
        public string ContagemDeNumerosRepitidos (int[] array, int comparador)
        {
            int numero = 0;
            int qtdDeRepetissoes = 0;
            foreach (var item in array)
            {
                if (item == comparador && array.GroupBy (x => x).Any (g => g.Count () > 1))
                {
                    numero = item;
                    qtdDeRepetissoes++;
                }
            }
            if (numero == 0) return "0";
            return $"O numero {numero} se repete {qtdDeRepetissoes}";
        }

    }
}