/*Напишите программу, которая на вход принимает два числа
и выдаёт большее число.

Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
if(first_number > second_number)
Console.WriteLine("Максимальное число это: " + first_number);
else 
Console.WriteLine("Максимальное число это: " + second_number);
*/

/*Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.Write("Максимальное число: " + max);
*/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if((num % 2) == 0)
Console.Write("Yes");
else Console.Write("No");
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/* 1 Вариант
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current < num)
{
    Console.Write(current + " ");
    current = current +2;
}
*/

/* 2 Вариант
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current < num)
{
    if((current % 2) == 0) 
        Console.Write(current + " ");
    current++;
}
*/
