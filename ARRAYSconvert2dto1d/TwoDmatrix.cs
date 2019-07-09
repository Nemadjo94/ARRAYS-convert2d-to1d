using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYSconvert2dto1d
{
    class TwoDmatrix
    {
        int rows, columns;
        int[,] a;
        int[] b;

        public TwoDmatrix()
        {
            rows = GetRows();
            columns = GetColumns();
            a = new int[rows, columns];
            b = new int[rows * columns];
        }

        public int GetRows()
        {
            Console.WriteLine("Enter number of rows :");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetColumns()
        {
            Console.WriteLine("Enter number of columns :");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ReadMatrix()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"a[{i}, {j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void PrintD()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    //Console.WriteLine($"{a[i, j]}\t");
                    Console.Write(string.Format($"{a[i, j]} "));
                }
                //Console.Write("\n");
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public void ConvertArray()
        {
            int k = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }

        public void PrintOneD()
        {
            for(int i = 0; i < rows * columns; i++)
            {
                Console.WriteLine($"{b[i]}\t");
            }
        }

        public void CallEverything()
        {
            Console.WriteLine("Enter the elements : ");
            this.ReadMatrix();

            Console.WriteLine("\t\t Given 2-D Array(Matrix) is :");
            this.PrintD();
            this.ConvertArray();

            Console.WriteLine("\t\t Converted 1-D Array is :");
            this.PrintOneD();
        }

    }
}
