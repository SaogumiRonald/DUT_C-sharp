using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            
            int nn = 0;
            bool isNNOk = false;
            int nk = 0;
            bool isNKOk = false;
            int k = 0;

            Console.WriteLine("Введіть значення змінних: ");
            do {
                Console.Write("Введіть значення змінної nn: ");
                string strN = Console.ReadLine();
                isNNOk = int.TryParse(strN, out nn);
                if (!isNNOk || nn <= 0) {
                    Console.WriteLine("Помилка введення значення змінної nn! Спробуйте ще раз:");
                }
            } while (!isNNOk || nn <= 0);

            do {
                Console.Write("Введіть значення змінної nk: ");
                string strN = Console.ReadLine();
                isNKOk = int.TryParse(strN, out nk);
                if (!isNKOk || nk <= nn) {
                    Console.WriteLine("Помилка введення значення змінної nk! Спробуйте ще раз:");
                }
            } while (!isNKOk || nk <= nn);
            
            double result = 1;
            for (k = nn; k <= nk; k++) {
                result *= ( Math.Pow((-1), (k*k)+k+1) * k*k ) / (2*(k*k)+5);
            }

            Console.WriteLine($"Результат обчислення: {result} (при nn = {nn}, nk = {nk})");
            
        }
    }
}