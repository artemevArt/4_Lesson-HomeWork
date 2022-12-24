// int RasingPositiveDegree(int num1, int num2)
// {
//     int result = 1;
//     for (int i = 0; i < num2; i++)
//     {
//         result = result * num1;
//     }
//     return result;
// }

// double RasingNegativeDegree(int num1, int num2)
// {
//     double result = 1;
//     num2 = num2 * (-1);
//     for (int i = 0; i < num2; i++)
//     {
//         result = result * num1;
//     }
//     result = 1 / result;
//     return result;
// }

// int a, b;

// Console.WriteLine("Введите число: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("В какую степень необходимо возвести число " + a + ":");
// b = Convert.ToInt32(Console.ReadLine());


// if (b == 0)
// {
//     Console.WriteLine("Любое число возведенное в 0 степень будет равняться 1!");
// }
// else if (b < 0)
// {
//     Console.WriteLine($"Число {a} в {b} степени = {RasingNegativeDegree(a, b)}");
// }
// else
//     if (b == 1) Console.WriteLine($"Число {a} в {b} степени = {a}");
// else
//     Console.WriteLine($"Число {a} в {b} степени = {RasingPositiveDegree(a, b)}");


// // В этом примере обращаюсь к элементу массива и проверяю его на соответсвие условию задачи 
// // (является ли элемент (число) массива делителем)

// int CountingSumOfDigits(int a, int[] b)
// {
//     int result = 0;
//     for (int i = 0; i < b.Length; i++)
//     {
//         if (b[i] == 0)
//         {
//             result = 0;
//         }
//         else
//             if (a % b[i] == 0)
//         {
//             result = result + b[i];
//         }
//     }
//     return result;
// }

// Console.WriteLine("Введите число для проверки: ");
// string num1 = Console.ReadLine();
// int[] num2 = num1.Select(num1 => Convert.ToInt32(Char.GetNumericValue(num1))).ToArray();
// int num3 = Convert.ToInt32(num1);

// int sumofdigits = CountingSumOfDigits(num3, num2);

// Console.WriteLine(sumofdigits);

// // В этом примере обращаюсь к числу, полученному при выполнении оператора остатка 
// // и проверяю его на соответсвие условию задачи (является ли число делителем)

// int CountingSumOfDigits(int a, string b)
// {
//     int sum = 0;
//     int c = a;
//     for (int i = 0; i < b.Length; i++)
//     {
//         int digit = c % 10;
//         if (a % digit == 0)
//         {
//             sum = sum + digit;
//         }
//         c = c / 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число для проверки: ");
// string num1 = Console.ReadLine();
// int num3 = Convert.ToInt32(num1);

// int sumofdigits = CountingSumOfDigits(num3, num1);

// Console.WriteLine(sumofdigits);