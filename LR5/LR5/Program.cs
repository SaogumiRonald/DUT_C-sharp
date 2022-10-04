using System;

namespace LR5 {
    internal class Program {
        
        static int getMatrixSize() {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1) {
                Console.WriteLine("Помилка введення! Спробуйте ще раз.");
                if (a <= 0) {
                    Console.WriteLine("Значення має бути більше нуля.");
                }
            }
            return a;
        }
        
        static int getValue() {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Помилка введення! Спробуйте ще раз.");
            }
            return a;
        }

        public static void Main(string[] args) {
            
            // Дана матриця розміру m *  n.
            // Видалити рядок (стовпчик), що містить
            // 1) мінімальний; 2) максимальний елемент матриці. 

            int n, m;
            int imax = 0, jmax = 0;
            int imin = 0, jmin = 0;

            Console.WriteLine("Введіть розмір матриці:");
            Console.Write("m = ");
            m = getMatrixSize();
            Console.Write("n = ");
            n = getMatrixSize();
            
            int[,] matrix = new int[m, n];
            Console.WriteLine("Введіть масив: ");
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.WriteLine($"Matrix[{i}][{j}]");
                    matrix[i, j] = getValue();
                }
            }

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i, j] > matrix[imax, jmax]) {
                        imax = i; jmax = j;
                    }
                }
            }
            
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i, j] < matrix[imin, jmin]) {
                        imin = i; jmin = j;
                    }
                }
            }

            Console.WriteLine("Введена матриця: ");
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            
            Console.WriteLine("Опрацьована матриця: ");
            for (int i = 0; i < m - 1; i++) {
                if (i == imax || i == imin) {
                    continue;
                }
                
                for (int j = 0; j < n; j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            
        }
    }
}