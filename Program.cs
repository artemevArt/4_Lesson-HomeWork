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