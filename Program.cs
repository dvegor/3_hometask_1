//First exercise

// Написать программу, которая на вход принимает число и выдает его квадрат (число умноденное само на себя)

// Console.WriteLine ("Input a number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = num * num;
// Console.WriteLine ($"Quarter of {num} is {res}");



//Second exercise
//Написать программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго

// Console.WriteLine ("Input a first number:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input a second number:");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x == y * y)
// {
//     Console.WriteLine ($"Second number {x} is quarter of first number {y}");
// }
// else
// {
//     Console.WriteLine ($"Second number {x} is not quarter of first number {y}");
// }

//Third exercise
//Написать программу, которая на вход принимает одночисло (N), а на выходе показывает все целые числа от 0 до N

// Console.WriteLine ("Input a number:");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (count<n)
// {
// Console.WriteLine(count);
// count++;
// }

//Написать программу, которая на вход принимает одночисло (N), а на выходе показывает все целые числа от -N до N
// Console.WriteLine ("Input a number:");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n*(-1);
// for(int i = current; i<=n; i++)
// {
// Console.Write($"{i}");
// }


//Fourth exercise
//Написать программу, которая принимает н вход трёхзначное число и на выходе показывает последнюю цифру этого числа
// Console.WriteLine ("Input a third char number:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<0)
// {
//     num = num * (-1);
// }
// if (num>99 && num <1000)
// {
// int res = num % 10;
// Console.WriteLine ($"Last numb is {res}");
// }
// else {
//     Console.WriteLine ("Wrong input");
// }


//Fifth exercise
//Написать программу, которая будет выдавать название дня недели по заданному номеру
// Console.WriteLine ("Input a number:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num>0 && num<8){
//     if(num == 1){
//         Console.WriteLine ("Monday");
//     }
//     else if (num == 2){
//         Console.WriteLine ("Tuesday");
//     }
//     else if (num == 3){
//         Console.WriteLine ("Wednesday");
//     }
//     else if (num == 4){
//         Console.WriteLine ("Thursday");
//     }
//     else if (num == 5){
//         Console.WriteLine ("Friday");
//     }
//     else if (num == 6){
//         Console.WriteLine ("Saturday");
//     }
//     else {
//         Console.WriteLine ("Sunday");
//     }
// }
//     else{
//         Console.WriteLine ("Wrong input");
//     }
