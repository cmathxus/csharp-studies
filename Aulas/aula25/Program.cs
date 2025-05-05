using System;

namespace aula25
{
    class Program
    {   
        static void Main(String[] args)
        {
            double[,] mat = new double [2,3];

            System.Console.WriteLine(mat.Length);
            System.Console.WriteLine(mat.Rank);
            System.Console.WriteLine(mat.GetLength(0));
            System.Console.WriteLine(mat.GetLength(1));
        }
    }
}