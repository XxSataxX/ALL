namespace mathes4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Console.WriteLine("Введите число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double sum = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Среднее арифметическое числа:");
            Console.WriteLine(sum);



            //2 задание
            Console.WriteLine("Введите два числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели числа " + a + " и " + b);
            Console.WriteLine("Какое действие выполнить?\r\n1. Сложение\r\n2. Вычитание\r\n3. Умножение\r\n4. Деление\r\n5. Нахождение остатка");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                double suma = a + b;
                Console.WriteLine("Результат: " + a + " + " + b + " = " + suma);
            }
            else if (choice == 2)
            {
                double subtraction = a - b;
                Console.WriteLine("Результат: " + a + " - " + b + " = " + subtraction);
            }
            else if (choice == 3)
            {
                double multiply = a * b;
                Console.WriteLine("Результат: " + a + " * " + b + " = " + multiply);
            }
            else if (choice == 4)
            {
                double divide = a / b;
                Console.WriteLine("Результат: " + a + " / " + b + " = " + divide);
            }
            else if (choice == 5)
            {
                double rema = a % b;
                Console.WriteLine("Результат: " + a + " % " + b + " = " + rema);
            }
            else
            {
                Console.WriteLine("Вы ввели не корректное число! Попробуйте ещё раз. ");
                choice = Convert.ToInt32(Console.ReadLine());
            }


            //3 задание
            Console.WriteLine("Выберите шкалу вводимой температуры:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите показатель температура (градусы):");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\r\n");
            int nam2 = Convert.ToInt32(Console.ReadLine());
            if (nam == 1 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Цельсий");
                Console.WriteLine("Результат конвертации: " + temp);
            }
            else if (nam == 1 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Кельвин");
                double kel = temp + 273;
                Console.WriteLine("Результат конвертации: " + kel);

            }
            else if (nam == 1 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Фаренгейт");
                double far = (temp + 273) * 1.8 - 459;
                Console.WriteLine("Результат конвертации: " + far);
            }
            else if (nam == 2 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Цельсий");
                double cel = temp - 273;
                Console.WriteLine("Результат конвертации: " + cel);
            }
            else if (nam == 2 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Кельвин ");
                Console.WriteLine("Результат конвертации: " + temp);
            }
            else if (nam == 2 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Фаренгейт");
                double far2 = temp * 1.8 - 459;
                Console.WriteLine("Результат конвертации: " + far2);

            }
            else if (nam == 3 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Цельсий");
                double cel2 = (temp - 32) / 1.8;
                Console.WriteLine("Результат конвертации: " + cel2);
            }
            else if (nam == 3 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Кельвин");
                double kel2 = (temp + 459) / 1.8;
                Console.WriteLine("Результат конвертации: " + kel2);
            }
            else if (nam == 3 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Фаренгейт");
                Console.WriteLine("Результат конвертации: " + temp);

            }
            //4задание
            {
                Console.WriteLine("Введите путь до файла:");
                string path = Console.ReadLine();

                // Разделяем путь по символам '/' и '\'
                string[] parts = path.Split(new char[] { '/', '\\' });

                // Выбираем последний элемент, который является именем файла
                string fileName = parts[parts.Length - 1];

                Console.WriteLine("Имя файла: " + fileName);
                //5задание
                {
                    Console.WriteLine("Введите предложение:");
                    string sentence = Console.ReadLine();

                    // Разделяем предложение на слова с помощью функции Split
                    string[] words = sentence.Split(' ');

                    string longestWord = "";
                    int longestLength = 0;

                    // Проходимся по каждому слову в массиве и проверяем его длину
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length > longestLength)
                        {
                            longestWord = words[i];
                            longestLength = words[i].Length;
                        }
                    }

                    Console.WriteLine($"Самое длинное слово: {longestWord}");



                    // 6 задание 
                    double[] array1 = new Double[10] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    double[] array2 = new Double[5] { 0, 1, 2, 3, 4 };
                    double[] array3 = new double[10];
                    int hold = 1;
                    int counter = 0;
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (i < array2.Length)
                        {
                            array3[i] = array1[i] * array2[i];
                        }
                        else
                        {
                            array3[i] = (array1[i] * hold);
                        }
                    }

                    foreach (int j in array3)
                    {
                        Console.WriteLine(j);
                    }

                    //7задание
                    {
                        Console.WriteLine("Введите пять чисел (через пробел):");
                        string input = Console.ReadLine();

                        // Разбиваем введенную строку на отдельные элементы
                        string[] numbersStr = input.Split(' ');

                        if (numbersStr.Length != 5)
                        {
                            Console.WriteLine("Необходимо ввести ровно пять чисел.");
                            return;
                        }

                        try
                        {
                            // Конвертируем строковые значения в целые числа
                            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

                            // Находим максимальное и минимальное значения
                            int maxNumber = numbers[0];
                            int minNumber = numbers[0];

                            for (int i = 1; i < 5; i++)
                            {
                                if (numbers[i] > maxNumber) maxNumber = numbers[i];
                                if (numbers[i] < minNumber) minNumber = numbers[i];
                            }

                            Console.WriteLine("Максимальное число: " + maxNumber);
                            Console.WriteLine("Минимальное число: " + minNumber);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }

                        //8 задание
                        {
                            Console.WriteLine("Введите количество ступеней:");
                            int levels;
                            bool isNumber = int.TryParse(Console.ReadLine(), out levels);

                            if (isNumber && levels > 0)
                            {
                                for (int i = 1; i <= levels; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write(j);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
                            }
                            //2часть 1 задание
                            {
                                for (int i = 1; i <= 9; i++) // Цикл для первого множителя
                                {
                                    for (int j = 1; j <= 9; j++) // Цикл для второго множителя
                                    {
                                        Console.Write($"{i} x {j} = {i * j}   "); // Вывод результата умножения
                                    }
                                    Console.WriteLine(); // Переход на новую строку после каждой строки таблицы

                                    //2часть 2 задание
                                    {
                                        // Заполним массив некоторыми примерными ценами для демонстрации
                                        decimal[] prices = new decimal[20]
                                        {
                                            150.50M, 200.25M, 75.80M, 110.00M, 90.30M,
                                            185.75M, 210.00M, 135.40M, 155.60M, 80.20M,
                                            190.10M, 210.00M, 125.25M, 170.75M, 145.90M,
                                            195.55M, 205.65M, 140.85M, 165.00M, 120.15M
                                        };

                                        decimal total = 0;
                                        for (int o = 0; o < prices.Length; o++)
                                        {
                                            total += prices[o];
                                        }

                                        decimal averagePrice = total / prices.Length;

                                        int countBelowAverage = 0;
                                        for (int o = 0; o < prices.Length; o++)
                                        {
                                            if (prices[o] < averagePrice)
                                            {
                                                countBelowAverage++;
                                            }
                                        }

                                        Console.WriteLine($"Средняя стоимость товаров: {averagePrice}");
                                        Console.WriteLine($"Количество товаров с ценой ниже среднего: {countBelowAverage}");
                                    }
                                }
                            }









                        }
                    }

                }
            }
        }
    }
}



