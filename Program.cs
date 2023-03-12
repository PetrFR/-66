//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число:");
int last = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных значений от {userInput} до {last} = {SummEl(userInput, last)}");


int SummEl(int inNum, int inNum2)
{
    if (inNum == inNum2)
    {
        return inNum;
    }
    else
    {
        return inNum + SummEl(inNum + 1, inNum2);
    }
}