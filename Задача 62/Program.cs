// Напишите метод, который заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Введите размер массива");
bool isParse = int.TryParse(Console.ReadLine(), out int m);
if(!isParse)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}

int[,] array = new int[m, m];

int n = 1;
int i = 0;
int j = 0;

while (n <= m * m)
{
    array[i, j] = n;
    if (i <= j + 1 && i + j < m - 1)
        j++;
    else if (i < j && i + j >= m - 1)
        i++;
    else if (i >= j && i + j > m - 1)
        j--;
    else
        i--;
    n++;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
