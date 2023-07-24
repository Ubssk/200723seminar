// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ackermann(int start, int end)
{
    if (start == 0) return end + 1;
    if (start > 0 && end == 0) return Ackermann(start - 1, 1);
    if (start > 0 && end > 0) return Ackermann(start - 1, Ackermann(start, end - 1));
    return Ackermann(start, end);
}
Console.WriteLine($"Функция Аккермана А({m},{n})= {Ackermann(m, n)}");