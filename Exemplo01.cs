using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Você pode percorrer os elementos da matriz com o forloop e usar a Length propriedade para especificar quantas vezes o loop deve ser executado.

O exemplo a seguir gera todos os elementos do array Doce:*/


namespace LoopMatrizes
{
    internal class Exemplo01
    {
        public static void Main(string[] args)
        {


            string[] Doce = { "Beijinho", "Brigadeiro", "Pavê", "Manjar" };
            for (int i = 0; i < Doce.Length; i++)
            {
                Console.WriteLine(Doce[i]);
            }
        }
    }
}
