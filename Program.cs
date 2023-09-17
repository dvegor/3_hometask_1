// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine ("Input a first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input a second number:");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if (a < b)
// {
// max = b;
// Console.WriteLine ($"Max number is {max}");
// } 
// if (b < a)
// {
// max = a;
// Console.WriteLine ($"Max number is {max}");
// } 
//  if (a==b)
// {
// max = a;
// Console.WriteLine ($"This numbers is equals");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine ("Input a first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input a second number:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input a third number:");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine ($"Max number is {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine ("Input a first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// int res = a % 2;
// if (res == 0)
// {
// Console.WriteLine ($"This number is even");
// }
// else
// {
// Console.WriteLine ($"This number is odd");    
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine ("Input a first number:");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count < n)
// {
// Console.WriteLine(count);
// count = count + 2;
// }
