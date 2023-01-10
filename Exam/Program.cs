using System;
class Program {
    // список кольорів автомобілів
    enum Colors {
        BLACK,
        WHITE,
        RED,
        GREEN,
        BLUE,
        BROWN,
    }

    static int getValue() {
        int a;
        while (!int.TryParse(Console.ReadLine(), out a)) {
            Console.WriteLine("Помилка введення! Спробуйте ще раз.");
        }
        return a;
    }

    // клас Автомобіль
    class Car {
        private string name;
        private Colors[] colors;
        private int yearOfIssue;
        private int price;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public Colors[] Colors {
            get { return colors; }
            set { colors = value; }
        }

        public int YearOfIssue {
            get { return this.yearOfIssue; }
            set { this.yearOfIssue = value; }
        }
        
        public int Price {
            get { return this.price; }
            set { this.price = value; }
        }

        public void printInfo() {
            Console.WriteLine("Назва моделі: " + this.name);

            Console.Write("Доступні кольори: ");
            foreach (var i in this.colors) {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Рік випуску: " + this.yearOfIssue);
            Console.WriteLine("Вартість моделі: " + this.price + "$");
            Console.WriteLine();
        }

        public Car(string name, Colors[] colors, int yearOfIssue, int price) {
            this.name = name;
            this.colors = colors;
            this.yearOfIssue = yearOfIssue;
            this.price = price;
        }

    }


    public static void Main(string[] args) {

        // ствоення 5 екземлярів класу
        Car CheryTiggo4 = new Car("Chery Tiggo 4", new Colors[] { Colors.BLACK, Colors.WHITE, Colors.GREEN, Colors.RED }, 2018, 16600);
        Car CheryTiggo7Pro = new Car("Chery Tiggo 7 Pro", new Colors[] { Colors.BLACK, Colors.WHITE }, 2020, 22200);
        Car GeelyAtlasPro = new Car("Geely Atlas Pro", new Colors[] { Colors.BLACK, Colors.WHITE, Colors.BLUE, Colors.GREEN }, 2019, 21140);
        Car HavalDargo = new Car("HavalDargo", new Colors[] { Colors.BLACK, Colors.WHITE, Colors.BROWN, Colors.BLUE }, 2020, 33700);
        Car CheryTiggo2Pro = new Car("Chery Tiggo 2 Pro", new Colors[] { Colors.BLACK, Colors.WHITE}, 2020, 13200);

        // підбір автомобіля
        Console.WriteLine("Оберіть необхідні параметри авто: ");

        // підбір ціни авто
        int customerPrice = 0;
        int choose = 0;
        bool correct = false;
        Console.WriteLine("Вартість автомобіля (1-5): ");
        Console.WriteLine("1) " + CheryTiggo4.Price + "$");
        Console.WriteLine("2) " + CheryTiggo7Pro.Price + "$");
        Console.WriteLine("3) " + GeelyAtlasPro.Price + "$");
        Console.WriteLine("4) " + HavalDargo.Price + "$");
        Console.WriteLine("5) " + CheryTiggo2Pro.Price + "$");

        while (!correct) {
            choose = getValue();
            switch (choose) {
                case 1:
                    customerPrice = CheryTiggo4.Price;
                    correct = true;
                    break;
                case 2:
                    customerPrice = CheryTiggo7Pro.Price;
                    correct = true;
                    break;
                case 3:
                    customerPrice = GeelyAtlasPro.Price;
                    correct = true;
                    break;
                case 4:
                    customerPrice = HavalDargo.Price;
                    correct = true;
                    break;
                case 5:
                    customerPrice = CheryTiggo2Pro.Price;
                    correct = true;
                    break;
                default:
                    Console.WriteLine("Некоректний ввід! Спробуйте ще раз:");
                    break;
            }
        }
        Console.WriteLine();


        // підбір року випуску авто
        choose = 0;
        correct = false;
        int customerYearOfIssue = 0;

        Console.WriteLine("Рік випуску (1-5): ");
        Console.WriteLine("1) " + CheryTiggo4.YearOfIssue);
        Console.WriteLine("2) " + CheryTiggo7Pro.YearOfIssue);
        Console.WriteLine("3) " + GeelyAtlasPro.YearOfIssue);
        Console.WriteLine("4) " + HavalDargo.YearOfIssue);
        Console.WriteLine("5) " + CheryTiggo2Pro.YearOfIssue);

        while (!correct) {
            choose = getValue();
            switch (choose) {
                case 1:
                    customerYearOfIssue = CheryTiggo4.YearOfIssue;
                    correct = true;
                    break;
                case 2:
                    customerYearOfIssue = CheryTiggo7Pro.YearOfIssue;
                    correct = true;
                    break;
                case 3:
                    customerYearOfIssue = GeelyAtlasPro.YearOfIssue;
                    correct = true;
                    break;
                case 4:
                    customerYearOfIssue = HavalDargo.YearOfIssue;
                    correct = true;
                    break;
                case 5:
                    customerYearOfIssue = CheryTiggo2Pro.YearOfIssue;
                    correct = true;
                    break;
                default:
                    Console.WriteLine("Некоректний ввід! Спробуйте ще раз:");
                    break;
            }
        }
        Console.WriteLine();


        // підбір кольору авто
        choose = 0;
        correct = false;
        int customerColor = 0;

        Console.WriteLine("Колір (1-6): ");
        Console.WriteLine("1) Чорний");
        Console.WriteLine("2) Білий");
        Console.WriteLine("3) Червоний");
        Console.WriteLine("4) Синій");
        Console.WriteLine("5) Зелений");
        Console.WriteLine("6) Коричневий");

        while (!correct) {
            choose = getValue();
            switch (choose) {
                case 1:
                    customerColor = (int)Colors.BLACK;
                    correct = true;
                    break;
                case 2:
                    customerColor = (int)Colors.WHITE;
                    correct = true;
                    break;
                case 3:
                    customerColor = (int)Colors.RED;
                    correct = true;
                    break;
                case 4:
                    customerColor = (int)Colors.GREEN;
                    correct = true;
                    break;
                case 5:
                    customerColor = (int)Colors.BLUE;
                    correct = true;
                    break;
                case 6:
                    customerColor = (int)Colors.BROWN;
                    correct = true;
                    break;
                default:
                    Console.WriteLine("Некоректний ввід! Спробуйте ще раз:");
                    break;
            }
        }
        Console.WriteLine();


        // перевірка умов
        if (customerPrice == CheryTiggo4.Price && customerYearOfIssue == CheryTiggo4.YearOfIssue && (customerColor == (int)CheryTiggo4.Colors[0] || customerColor == (int)CheryTiggo4.Colors[1] || customerColor == (int)CheryTiggo4.Colors[2] || customerColor == (int)CheryTiggo4.Colors[3])) {
            Console.WriteLine("Автомобіль що підходить під ваші потреби: ");
            CheryTiggo4.printInfo();
        }
        else if (customerPrice == CheryTiggo7Pro.Price && customerYearOfIssue == CheryTiggo7Pro.YearOfIssue && (customerColor == (int)CheryTiggo7Pro.Colors[0] || customerColor == (int)CheryTiggo7Pro.Colors[1])) {
            Console.WriteLine("Автомобіль що підходить під ваші потреби: ");
            CheryTiggo7Pro.printInfo();
        }
        else if (customerPrice == GeelyAtlasPro.Price && customerYearOfIssue == GeelyAtlasPro.YearOfIssue && (customerColor == (int)GeelyAtlasPro.Colors[0] || customerColor == (int)GeelyAtlasPro.Colors[1] || customerColor == (int)GeelyAtlasPro.Colors[2]) || customerColor == (int)GeelyAtlasPro.Colors[3]) {
            Console.WriteLine("Автомобіль що підходить під ваш потреби: ");
            GeelyAtlasPro.printInfo();
        }
        else if (customerPrice == HavalDargo.Price && customerYearOfIssue == HavalDargo.YearOfIssue && (customerColor == (int)HavalDargo.Colors[0] || customerColor == (int)HavalDargo.Colors[1] || customerColor == (int)GeelyAtlasPro.Colors[2]) || customerColor == (int)GeelyAtlasPro.Colors[3]) {
            Console.WriteLine("Автомобіль що підходить під ваші потреби: ");
            HavalDargo.printInfo();
        }
        else if (customerPrice == CheryTiggo2Pro.Price && customerYearOfIssue == CheryTiggo2Pro.YearOfIssue && (customerColor == (int)CheryTiggo2Pro.Colors[0] || customerColor == (int)CheryTiggo2Pro.Colors[1])) {
            Console.WriteLine("Автомобіль що підходить під ваші потреби: ");
            CheryTiggo2Pro.printInfo();
        }
        else {
            Console.WriteLine("Нажаль, підходящого автомобілю не знайдено.");
        }

        // Затримка
        Console.ReadLine();
    }
}