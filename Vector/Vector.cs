using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVector
{
    public class Vector<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public double length { get; set; }

        public string nameVector { get; set; }

        public Vector(string nameVector, T x, T y)
        {
            this.nameVector = nameVector;
            X = x;
            Y = y;
            length = Math.Sqrt(Math.Pow((dynamic)x, 2) + Math.Pow((dynamic)y, 2));
        }
    }
}
