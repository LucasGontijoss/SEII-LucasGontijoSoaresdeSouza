using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class exemplo08
    {
        public static void Main(string[] args)
        {
            string pasta = "Nova pasta";
            Directory.CreateDirectory(pasta);
            Console.ReadKey(true);
        }
    }
}