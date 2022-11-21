/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

Console.WriteLine("Enter the Number1");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Number2");
int Number2 = Convert.ToInt32(Console.ReadLine());
int quadro1 = Quadro(Number1);
int quadro2 = Quadro(Number2);

if (quadro1 == Number2  || quadro2 == Number1)
{
Console.Write("True");
}
else 
{
  Console.Write("False");  
}

int Quadro (int a)
{
    return a * a;
}
Console.WriteLine();