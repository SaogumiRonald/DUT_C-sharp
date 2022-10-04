using System;
using System.Collections.Generic;

namespace LR4{
    internal class Program {
        
        static int getArraySize() {
            Console.WriteLine("Введіть розмір масиву: ");
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
            
            // Даний масив цілих чисел розміру N.
            // Перетворити масив, збільшивши (зменшивши)
            // кожну його серію на один елемент. 
            
            int n = getArraySize();
            int[] array1 = new int[n];
            List<int> array2 = new List<int>();

            Console.WriteLine("Введіть масив: ");
            for (int i = 0; i < array1.Length; i++) {
                Console.Write($"array[{i}] = ");
                array1[i] = getValue();
            }
            
            for (int i = 0; i < array1.Length - 1; i++) {
                if (array1[i] == array1[i + 1]) {
                    array2.Add(array1[i]);
                } else {
                    array2.Add(array1[i]);
                    array2.Add(array1[i]);
                }
            }
            array2.Add(array1[array1.Length - 1]);
            array2.Add(array1[array1.Length - 1]);
            
            Console.WriteLine("Опрацьованый масив: ");
            foreach (var i in array2) {
                Console.Write($"{i} ");
            }
            
        }
    }
}