using System;

namespace _07_Arrays
{
    class Program
    {

        static int[,] matrix =
        {
            //// declare 2D Array
            //string[,] matrix;

            ////3D Array
            //int[,,] threeD;

            //// two dimensional array
            //int[,] array2D = new int[,]
  
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.WriteLine(item + " ");
            }

        }

    }
}