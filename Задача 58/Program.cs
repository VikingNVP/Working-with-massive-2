// Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите размерность квадратных матриц М: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if(!isParsedM)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}

int[,] matrixA = new int[m, m];
FillArrayRandomNumbers(matrixA);
int[,] matrixB = new int[m, m];
FillArrayRandomNumbers(matrixB);
Console.WriteLine();
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixC = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            matrixC[i, j] = matrixA[i, k] * matrixB[k, j];
        }
    }
}
Console.WriteLine("Произведение матриц А * В");
Console.WriteLine();
PrintArray(matrixC);
