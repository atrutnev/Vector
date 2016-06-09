using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector<T> where T : struct, IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }

        public double length { get; set; }

        public string nameVector { get; set; }

        public Vector(string nameVector, T x, T y)
        {
            this.nameVector = nameVector;
            this.X = x;
            this.Y = y;
            this.length = Math.Sqrt(Math.Pow((dynamic)x, 2) + Math.Pow((dynamic)y, 2));
        }

        public Vector()
        {
        }

        //Формат отображения
        public override string ToString()
        {
            return string.Format("Вектор - {0} [X: {1}, Y: {2} Длина: {3:F2}]", nameVector, X, Y, length);
        }

        //Операция сложения
        public static Vector<T> operator +(Vector<T> firstVector, Vector<T> secondVector)
        {
            return new Vector<T>("P", (dynamic)firstVector.X + (dynamic)secondVector.X, (dynamic)firstVector.Y + (dynamic)secondVector.Y);
        }

        //Операция вычитания
        public static Vector<T> operator -(Vector<T> firstVector, Vector<T> secondVector)
        {
            return new Vector<T>("M", (dynamic)firstVector.X - (dynamic)secondVector.X, (dynamic)firstVector.Y - (dynamic)secondVector.Y);
        }

        //Сравнение "больше"
        public static bool operator >(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo((dynamic)secondVector) > 0);
        }

        //Сравнение "меньше"
        public static bool operator <(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo((dynamic)secondVector) < 0);
        }

        //Сравнение "равно"
        public static bool operator ==(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo((dynamic)secondVector) == 0);
        }

        //Сравнение "не равно"
        public static bool operator !=(Vector<T> firstVector, Vector<T> secondVector)
        {
            return ((dynamic)firstVector.CompareTo((dynamic)secondVector) != 0);
        }


        //Метод сравнения векторов по их длине
        public int CompareTo(Vector<T> secondVector)
        {
            if (length > secondVector.length)
                return 1;
            if (length < secondVector.length)
                return -1;
            else
                return 0;
        }

        //Метод Equals
        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }

        //Метод GetHashCode
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
