using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//O exemplo a seguir gera todos os elementos do array cars , usando um foreachloop:

namespace LoopMatrizes
{
    internal class Exemplo02
    {
        public static void Main(string[] args)
        {
            string[] Animal = { "Gato", "Galinha", "Coelho", "Elefante" };
            foreach (string i in Animal)
            {
                Console.WriteLine(i);
            }
        }
    }
}
