// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Summa(m, n, 0);

void Summa (int numM, int numN, int sum)
{
    if (numN < numM) 
    {
        System.Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}"); 
        return;
    }
    sum = sum + (numM++);
    Summa(numM, numN, sum);
}
