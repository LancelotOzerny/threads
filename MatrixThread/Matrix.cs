using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixThread
{
    internal class Matrix
    {
        // Скрытые поля
        private int _size;
        private int[,] _values;
        private static Random rand = new Random();

        public int Size
        {
            get { return _size; }
            set { if (value > 0) _size = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                return _values[i, j];
            }
            set
            {
                _values[i, j] = value;
            }
        }

        public Matrix(int _size, bool randValues = false)
        {
            this._size = _size;
            _values = new int[this._size, this._size];

            if (randValues)
            {
                for (int i = 0; i < this.Size; i++)
                {
                    for (int j = 0; j < this.Size; j++)
                    {
                        this[i, j] = rand.Next(-10, 10);
                    }
                }
            }
        }

        /// <summary>
        /// Умножение матрицы А на матрицу Б
        /// </summary>
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Size);

            for (int i = 0; i < a.Size; i++)
            {
                for (int j = 0; j < b.Size; j++)
                {
                    for (int k = 0; k < b.Size; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// перегрузка оператора умножения
        /// </summary>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.Multiply(a, b);
        }
    }
}
