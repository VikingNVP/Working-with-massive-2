//  Задайте двумерный массив. Напишите метод, который упорядочит по убыванию элементы каждой строки двумерного массива. И продемонстрируйте его работу.
/* Например, задан массив:
   1 4 7 2
   5 9 2 3
   8 4 2 4
   В итоге получается вот такой массив:
   7 4 2 1
   9 5 3 2
   8 4 4 2 */

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
int[,] array = FillArray2D(m, n);
PrintArray2D(array);
int[,] result = SortingArray(array, m, n);
Console.WriteLine();
PrintSortedArray2D(result);

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
}

int[,] SortingArray(int[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if(array[i, a] < array[i, a + 1])
               {
                int help = 0;
                help = array[i, a];
                array[i, a] = array[i, a + 1];
                array[i, a + 1] = help;
               }
            }
        }
    }
    return array;
}

void PrintSortedArray2D(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i,j]} "); 
        }
        Console.WriteLine();
    }
}
