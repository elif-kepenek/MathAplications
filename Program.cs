﻿namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(2,4);

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("{0}", Matrix.Determinant(Matris));
        }
    }
    
}