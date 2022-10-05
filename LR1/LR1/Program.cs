using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            double t = 0;
            double v0 = 0;
            bool isVOk = false;
            double h = 0;
            bool isHOk = false;
            const double G = 9.8;

            Console.WriteLine("Введіть значення змінних: ");
            do {
                Console.Write("Введіть початкову швидкість v0 (м/с): ");
                string strV = Console.ReadLine();
                isVOk = double.TryParse(strV, out v0);
                if (!isVOk || v0 <0) {
                    Console.WriteLine("Помилка введення значення змінної v0! Спробуйте ще раз:");
                }
            } while (!isVOk || v0 < 0);

            do {
                Console.Write("Введіть висоту h (м): ");
                string strH = Console.ReadLine();
                isHOk = double.TryParse(strH, out h);
                if (!isHOk || h < 0) {
                    Console.WriteLine("Помилка введення значення змінної h! Спробуйте ще раз:");
                }
            } while (!isHOk || h < 0);

            t = Math.Sqrt(2 * (h + v0) / G);
            Console.WriteLine($"Час падіння t с: {t}");
            
        }
    }
}