using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Введите строку произвольной длины:");
string str = Console.ReadLine();
Console.WriteLine("Введите символ для того что бы найти процент его вхождения в строку:");
char sym = Console.ReadKey().KeyChar;
Console.WriteLine();

int length = str.Length;
char[] strArr = str.ToCharArray();
int counter = 0;
for (int i = 0; i < length; i++)
{
    if (strArr[i] == sym)
    {
        counter++;
    }
}
double lengthDouble = Convert.ToDouble(length);
double counterDouble = Convert.ToDouble(counter);
double prc = (counterDouble / lengthDouble) * 100;
Console.WriteLine($"Процент вхождения символа {sym} равен {prc}%");

Console.WriteLine("Задание No2:");
Console.WriteLine("Задание No2:");
Console.WriteLine("Задание No2:");

int[,] M = new int[10, 10];
Random random = new Random();
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        M[i, j] = random.Next(1, 50);
        Console.Write(M[i, j] + " ");
    }
    Console.WriteLine();
}
int max = M[0, 0];
for (int i = 0; i < M.GetLength(0); i++)
{
    double pr = 1;
    double sum = 0;
    for (int j = 0; j < M.GetLength(1); j++)
    {
        pr = pr * M[j, i];
        sum = sum + M[i, j];
        if (i == j)
            if (max < M[i, j])
                max = M[i, j];
    }
    Console.WriteLine("Произведение " + (i + 1) + " столбца=" + pr);
    Console.WriteLine("Сумма " + (i + 1) + " строки=" + sum);
}
Console.WriteLine("Максимальный элемент в диагонали матрицы " + max);