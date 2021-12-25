Random rnd = new Random();

// 0. Вывести квадрат числа
// int Square(int number) { 
//     return number * number;
// }
// Console.WriteLine(Square(5));

// 1. По двум заданным числам проверять является ли первое квадратом второго
// bool CheckSquare(int number1, int number2) {
//     if (number1 == number2 * number2) return true;
//     else return false;
// }
// Console.WriteLine(CheckSquare(25, 5));

// 2. Даны два числа. Показать большее и меньшее число
// string Value(int number1, int number2) {
//     string value = string.Empty;
//     if (number1 > number2) {value = $"max = {number1}, min = {number2}";}
//     else {value = $"max = {number2}, min = {number1}";}
//     return value;
// }
// Console.WriteLine(Value(12, 30));

// 3. По заданному номеру дня недели вывести его название
// string WeekDays(int number) {
//     string[] weekDays = { "0", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
//     return weekDays[number];
// }
// Console.WriteLine(WeekDays(1));

// 4. Найти максимальное из трех чисел
// int FindMax(int number1, int number2, int number3) {
//     int max = number1;
//     if (number2 > max) max = number2;
//     if (number3 > max) max = number3;
//     return max;
// }
// Console.WriteLine(FindMax(2, 11, -7));

// 5. Написать программу вычисления значения функции y=f(a)
// double Function(double degrees) {
//     double a = Math.PI * degrees / 180.0;
//     return Math.Sin(a);
// }
// Console.WriteLine(Function(90));

// 6. Выяснить является ли число чётным
// bool IfEven(int number) {
//     if (number % 2 == 0) return true;
//     else return false;
// }
// Console.WriteLine(IfEven(22));

// 7. Показать числа от -N до N
// int a1 = -10;
// int a2 = 10;
// Console.WriteLine($"{a1} .. {a2}");

// 8. Показать четные числа от 1 до N
// void EvenNumbers(int N) {
//     int number = 1;
//     for (int index = 1; index <= N; index++)
//     {
//         if (number % 2 == 0) Console.Write($"{number} ");
//         number++;
//     }
// }
// EvenNumbers(20);

// 9. Показать последнюю цифру трёхзначного числа
// int LastDigit(int number) {
//     return number % 10;
// }
// Console.WriteLine(LastDigit(213));

// 10. Показать вторую цифру трёхзначного числа
// int SecondDigit(int number) {
//     return number % 100 / 10;
// }
// Console.Write(SecondDigit(213));

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int MaxDigit(int number) {
//     int a = number / 10;
//     int b = number % 10;
//     if (a > b) return a;
//     else return b;
// }
// int number = rnd.Next(10, 100);
// Console.Write($"{number} {MaxDigit(number)}");

// 12. Удалить вторую цифру трёхзначного числа
// string RemoveSecondDigit(int number) {
//     int a = number / 100;
//     int b = number % 10;
//     return $"{a}{b}";
// }
// int number = rnd.Next(100, 1000);
// Console.Write($"{number} {RemoveSecondDigit(number)}");

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// string IfEven(double number, double uNumber) {
//     if (number % uNumber != 0) return $"Remainder = {number % uNumber}";
//     else return $"The number is divisible by {uNumber}";
// }
// Console.WriteLine(IfEven(20, 3));

// 14. Найти третью цифру числа или сообщить, что её нет
// string CheckThirdDigit(int number) {
//     if (number > 99) return $"{number = number / 100 % 10}";
//     else return "Third digit not found";
// }
// Console.WriteLine(CheckThirdDigit(438298));


// 15. Дано число. Проверить кратно ли оно 7 и 23
// bool IfDivisible(int number) {
//     if (number % 7 == 0 && number % 23 == 0) return true;
//     else return false;
// }
// Console.WriteLine(IfDivisible(161));

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// bool IfHoliday(int number) {
//     if (number == 1 || number == 6) return true;
//     else return false;
// }
// Console.WriteLine(IfHoliday(1));

// 17. По двум заданным числам проверять является ли одно квадратом другого
// bool CheckSquare(int number1, int number2) {
//     if ((number1 == number2 * number2 || number2 == number1 * number1)) return true;
//     else return false;
// }
// Console.WriteLine(CheckSquare(2, 8));

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool IfTrue (bool x, bool y) {
//     if (!(x | y) == (!x & !y)) return true;
//     else return false;
// }
// Console.WriteLine(IfTrue(true, true));

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int Value(int x, int y) {
//     int number = 0;
//     if (x == 0 | y == 0) number = -1;
//     else if (x > 0 & y > 0) number = 1;
//     else if (x > 0 & y < 0) number = 2;
//     else if (x < 0 & y < 0) number = 3;
//     else if (x < 0 & y > 0) number = 4;
//     return number;
// }
// Console.Write(Value(0, 0));

// 20. Задать номер четверти, показать диапазоны для возможных координат
// string Value(int x, int y) {
//     string res = string.Empty;
//     if (x == 0 | y == 0) res = $"-1";
//     else if (x > 0 & y > 0) res = $"1; x(0, +▲), y(0, +▲)";
//     else if (x > 0 & y < 0) res = $"2; x(0, +▲), y(0, -▲)";
//     else if (x < 0 & y < 0) res = $"3; x(0, -▲), y(0, -▲)";
//     else if (x < 0 & y > 0) res = $"4; x(0, -▲), y(0, +▲)";
//     return res;
// }
// Console.Write(Value(1, 1));

// 21. Программа проверяет пятизначное число на палиндромом.
// bool IfPalindrome(int number) {
//     if ((number % 10 == number % 100000 / 10000) && (number % 100 / 10 == number % 10000 / 1000)) return true;
//     else return false;
// }
// Console.Write(IfPalindrome(65556));

// 22. Найти расстояние между точками в пространстве 2D/3D
// double Distance(int x1, int y1, int z1, int x2, int y2, int z2) {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }
// Console.Write(Distance(1, 3, 2, 1, 0, 6));


// 23. Показать таблицу квадратов чисел от 1 до N
// string ShowSquare(int N) {
//     string number = string.Empty;
//     int start = 1;
//     for (int index = 1; index <= N; index++)
//     {
//         number = $"{number}{start}² = {start * start}  ";
//         start++;
//     }
//     return number;
// }
// Console.Write(ShowSquare(10));

// 24. Найти кубы чисел от 1 до N
// string ShowCube(int N) {
//     string number = string.Empty;
//     int start = 1;
//     for (int index = 1; index <= N; index++)
//     {
//         number = $"{number}{start}^3 = {Math.Pow(start, 3)}  ";
//         start++;
//     }
//     return number;
// }
// Console.Write(ShowCube(10));

// 25. Найти сумму чисел от 1 до А
// int FindSum(int A) {
//     int number = 1;
//     int sum = 0;
//     for (int index = 1; index <= A; index++)
//     {
//         sum += number;
//         number++;
//     }
//     return sum;
// }
// Console.WriteLine(FindSum(25));

// 26. Возведите число А в натуральную степень B используя цикл
// string Exponent(int A, int B) {
//     int S = 1;
//     for (int i = 0; i < B; i++)
//     {
//         S *= A;
//     }
//     return $"{A}^{B} = {S}";
// }
// Console.WriteLine(Exponent(2, 5));

// 27. Определить количество цифр в числе
// int FindNumber(string number) {
//     return number.Length;
// }
// Console.WriteLine(FindNumber(234432.ToString()));

// 28. Подсчитать сумму цифр в числе
// int FindSum(int num) {
//     int sum = 0;
//     for (int n = num; n > 0; sum += n % 10, n /= 10);
//     return sum;
// }
// Console.WriteLine(FindSum(2418));

// 29. Написать программу вычисления произведения чисел от 1 до N
// int Product(int N) {
//     int product = 1;
//     for (int num = 1; num <= N; num++)
//     {
//         product *= num;
//     }
//     return product;
// }
// Console.WriteLine(Product(5));

// 30. Показать кубы чисел, заканчивающихся на четную цифру
// string ShowEvenCube(int N) {
//     string number = string.Empty;
//     int start = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         if (start % 2 == 0) number = $"{number}{i}^3 = {Math.Pow(start, 3)}  ";
//         start++;
//     }
//     return number;
// }
// Console.WriteLine(ShowEvenCube(10));

// 31. Задать массив из 8 элементов и вывести их на экран 
// void PrintArray(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = rnd.Next(0,100);
//         Console.Write($"{arr[index]} ");
//     }
// }
// int[] array = new int[8];
// PrintArray(array);

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// void PrintArray(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = rnd.Next(0,2);
//         Console.Write($"{arr[index]} ");
//     }
// }
// int[] array = new int[8];
// PrintArray(array);

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
// int FindSum(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = rnd.Next(-9, 10);
//         Console.Write($"{arr[index]} ");
//     }
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         sum += arr[index];
//     }
//     Console.WriteLine();
//     return sum;
// }
// int[] array = new int[12];
// Console.WriteLine(FindSum(array));

// 34. Написать программу замену элементов массива на противоположные
// void ChangeElement(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = arr[index] * (-1);
//         Console.Write($"{arr[index]} ");
//     }
// }
// int[] array = { -1, 2, 3, -4, -5, 6, 7, 8, -9, 10 };
// ChangeElement(array);

// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// bool CheckNumber(int[] arr, int number) {
//     if (arr.Contains(number)) return true;
//     else return false;
// }
// int[] array = { -1, 2, 3, -4, -5, 6, 7, 8, -9, 10 };
// Console.WriteLine(CheckNumber(array, 2));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// void ShowNumbers(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = rnd.Next(100, 1000);
//         Console.Write($"{arr[index]} ");
//     }
//     int even = 0;
//     int odd = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         if (arr[index] % 2 == 0) even++;
//         else odd++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"even: {even}, odd: {odd}");
// }
// int[] array = new int[10];
// ShowNumbers(array);

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int NumberOfElements(int[] arr) {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = rnd.Next(-100, 1000);
//         Console.Write($"{arr[index]} ");
//     }
//     int count = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         if (arr[index] >= 10 && arr[index] <= 99) count++;
//     }
//     Console.WriteLine();
//     return count;
// }
// int[] array = new int[123];
// Console.WriteLine(NumberOfElements(array));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int Sum(int[] arr) {
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         if (arr[index] % 2 != 0) sum += arr[index];
//     }
//     return sum;
// }
// int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Console.WriteLine(Sum(array));

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// void Product(int[] arr) {
//     int first = 0;
//     int second = 9;
//     int product = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         Console.WriteLine($"{arr[first]} * {arr[second]} = {product = arr[first] * arr[second]}");
//         first++;
//         second--;
//     }
// }
// int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Product(array);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// double Difference(double[] arr) {
//     double min = arr[0];
//     double max = arr[0];
//     double dif = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         if (arr[index] > max) max = arr[index];
//         if (arr[index] < min) min = arr[index];
//     }
//     return dif = max - min;
// }
// double[] array = new double[] { 1.483, 2.22, 0.3, 0.454, 519.25, 6.241, 0.07, 12.8, 9.91, 10.234 };
// Console.WriteLine(Difference(array));


// 41. Выяснить являются ли три числа сторонами треугольника 
// bool IfTriangle(int a, int b, int c) {
//     if ((a + b > c) && (b + c > a) && (a + c > b)) return true;
//     else return false;
// }
// Console.WriteLine(IfTriangle(2,3,6));

// 42. Определить сколько чисел больше 0 введено с клавиатуры
// Console.Write("Enter numbers: ");
// string numbers = Console.ReadLine()!;
// if (numbers == null) numbers = "0";
// int Count(string str) {
//     int count = 0;
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (str.Substring(i, 1) != "0") count++;
//     }
//     return count;
// }
// Console.WriteLine(Count(numbers));

// 43. Написать программу преобразования десятичного числа в двоичное
// string ToBinary(int decimalNumber) {
//     string binary = string.Empty;
//     while (decimalNumber > 0)
//     {
//         int remainder = decimalNumber % 2;
//         binary = $"{remainder}{binary}";
//         decimalNumber = decimalNumber / 2;
//     }
//     return binary;
// }
// Console.WriteLine(ToBinary(5782));

// 45. Показать числа Фибоначчи
// double Fibonacci(int n) {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 31; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }


// Recursion

// 66. Показать натуральные числа от 1 до N, N задано
// string NaturalNumbers(int N) {
//     if (N == 1) return "1";
//     else return $"{NaturalNumbers(N - 1)} {N}";
// }
// Console.WriteLine(NaturalNumbers(10));

// 67. Показать натуральные числа от N до 1, N задано
// string NaturalNumbers(int N) {
//     string numbers = string.Empty;
//     if (N == 1) return "1";
//     if (N <= 0) {numbers = $"{N} {NaturalNumbers(N + 1)}";}
//     else numbers = $"{N} {NaturalNumbers(N - 1)}";
//     return numbers;
// }
// Console.WriteLine(NaturalNumbers(10));