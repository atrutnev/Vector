using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVector;

namespace TestVector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vectors = new List<int>();
            var g = new Generator<int>();
            g.ToList();

            foreach (var v in g)
            {
                Console.WriteLine(v);
            }
        }
    }
}
