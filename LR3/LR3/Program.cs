using System;

namespace LR3 {
    internal class Program {
        static int getCoordinate() {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Помилка введення! Спробуйте ще раз.");
            }
            return a;
        }

        public static void Main(string[] args) {
            // Перевірити істинність вислову:
            // "Точка з координатами (x, у) лежить всередині прямокутника,
            // ліва верхня вершина якого має координати (x1, y1),
            // права нижня — (x2, y2), а сторони паралельні координатним осям".

            int x, y, x1, x2, y1, y2;

            Console.WriteLine("Введіть координати точки: ");
            Console.Write("X = ");
            x = getCoordinate();
            Console.Write("Y = ");
            y = getCoordinate();

            Console.WriteLine("Введіть координати прямокутника:");
            Console.Write("X1 = ");
            x1 = getCoordinate();
            Console.Write("Y1 = ");
            y1 = getCoordinate();
            Console.Write("X2 = ");
            x2 = getCoordinate();
            Console.Write("Y2 = ");
            y2 = getCoordinate();

            if ((x > x1) && (x < x2) && (y < y1) && (y > y2)) {
                Console.WriteLine($"Точка ({x}, {y}) лежить в середині прямокутника ({x1}, {y1}; {x2}, {y2})");
            } else {
                Console.WriteLine($"Точка ({x}, {y}) не лежить в середині прямокутника ({x1}, {y1}; {x2}, {y2})");
            }
            
        }
    }
}