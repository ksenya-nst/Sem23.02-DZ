// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Akkerman(A, m, n);

void Akkerman(int A, int numM, int numN)
{
    if (numM = 0)
    {
        return numN + 1;
    }
    else if (numN = 0 && numM > 0)
    {
        return A(numM - 1, numN);
    }
    else if (numM > 0 && numN > 0)
    {
        return A(numM - 1, A(numM, numN - 1));
    }
    Akkerman(A, numM, numN);
    System.Console.WriteLine(A(m, n)); 
}
