/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

int Number = new Random().Next(100,999);
int NewNumber = 0;

int NumberWilhoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWilhoutSecDig();

Console.WriteLine();
Console.WriteLine($"Если из числа {Number} Удалить вторую цифру, получится число {NewNumber}");
Console.WriteLine();