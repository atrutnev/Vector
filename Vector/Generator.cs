using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVector
{
    public class Generator<T> : IEnumerable<Vector<T>> where T : struct
    {
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            Random ran = new Random();

            for (int i = 0; i < 5; i++)
            {
                yield return new Vector<T>(string.Format("{0}", (char)ran.Next(65, 90)), (dynamic)ran.Next(1, 40), (dynamic)ran.Next(1, 40));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
