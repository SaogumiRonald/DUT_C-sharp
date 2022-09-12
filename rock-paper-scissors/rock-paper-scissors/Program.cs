using System;
 
namespace ProgramStructure {
    class Program {
        static void Main(string[] args) {

            int pValue = 0;
            int cValue = 0;

            int playerTurn() {
                bool correctPValue = false;
                do {
                    Console.WriteLine("Ваш ход. Выберите:\n1) Камень;\n2) Ножницы;\n3) Бумага;\n");
                    pValue = Convert.ToInt32(Console.ReadLine());
                    if (pValue == 1 || pValue == 2 || pValue == 3) {
                        correctPValue = true;
                    } else {
                        Console.WriteLine("Некоректный ввод. Попробуйте ещё раз:");
                        correctPValue = false;
                    }
                } while (!correctPValue);
                
                return pValue;
            }

            int computerTurn() {
                Random rand = new Random();
                cValue = rand.Next(1, 4);

                return cValue;
            }

            void showValues(int pValue, int cValue) {
                switch (pValue) {
                    case 1: Console.WriteLine("Ваш выбор: камень.\n"); break;
                    case 2: Console.WriteLine("Ваш выбор: ножницы.\n"); break;
                    case 3: Console.WriteLine("Ваш выбор: бумага.\n"); break;
                    default: Console.WriteLine("Выбор игрока: не определено.\n"); break;
                }

                switch (cValue) {
                    case 1: Console.WriteLine("Выбор компьютера: камень.\n"); break;
                    case 2: Console.WriteLine("Выбор компьютера: ножницы.\n"); break;
                    case 3: Console.WriteLine("Выбор компьютера: бумага.\n"); break;
                    default: Console.WriteLine("Выбор компьютера: не определено.\n"); break;
                }
            }

            int whoWin(int pValue, int cValue) {
                showValues(pValue, cValue);
                if ((pValue == 1) && (cValue == 1) || (pValue == 2) && (cValue == 2) || (pValue == 3) && (cValue == 3)) {
                    Console.WriteLine("Ничья.\n");
                }

                if ((pValue == 1) && (cValue == 2) || (pValue == 2) && (cValue == 3) || (pValue == 3) && (cValue == 1)) {
                    Console.WriteLine("Победил игрок. \n");
                }

                if ((cValue == 1) && (pValue == 2) || (cValue == 2) && (pValue == 3) || (cValue == 3) && (pValue == 1)) {
                    Console.WriteLine("Победил компьютер.\n)");
                }

                return 1;
            }

            bool restart() {
                bool run = true;
                int wantToPlay = 1;

                bool correctPValue = false;
                do {
                    Console.WriteLine("Хотите сыграть ещё?\n1) Да\n2) Нет\n");
                    wantToPlay = Convert.ToInt32(Console.ReadLine());
                    if (wantToPlay == 1 || wantToPlay == 2) {
                        correctPValue = true;
                    } else {
                        Console.WriteLine("Некоректный ввод. Попробуйте ещё раз:");
                        correctPValue = false;
                    }
                } while (!correctPValue);

                switch (wantToPlay) {
                    case 1: run = true; break;
                    case 2: run = false; break;
                }

                return run;
            }

            do {
                playerTurn();
                computerTurn();
                whoWin(pValue, cValue);
            } while (restart());

        }
    }
}