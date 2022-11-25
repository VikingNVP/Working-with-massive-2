// Задайте двумерный массив. Напишите метод, который будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите кол-во строк М: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите кол-ко столбцов N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}
int[,] array = new int[m, n];
FillArrayRandomNumbers(array);
PrintArray(array);
int minSum = Int32.MaxValue;
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        index++;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (index) + ", Сумма элементов равна: " + (minSum));

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
        Console.WriteLine("");
    }
}
