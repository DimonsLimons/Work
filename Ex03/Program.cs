/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/
int Number1 = new Random().Next(1,100);
int Number2 = new Random().Next(1,100);
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}

MultipleNumber();
Console.WriteLine();
if (result == 0) Console.WriteLine($"Число {Number1} Кратно числу {Number2}");
else 
{
    Console.WriteLine($"Число {Number1} Не кратно числу  {Number2}, остаток от деления равен {Number1 % Number2}");
}

Console.WriteLine();