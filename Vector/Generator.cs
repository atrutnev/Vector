using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Generator<T> : IEnumerable<Vector<T>> where T : struct, IComparable
    {
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            Random ran = new Random();
            int j = 65;
            for (int i = 0; i < 5; i++)
            {
                 yield return new Vector<T>(string.Format("{0}", (char)j), (dynamic)ran.Next(1, 40), (dynamic)ran.Next(1, 40));
                 j++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
