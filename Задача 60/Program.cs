// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите размерность 1: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите размерность 2: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите размерность 3: ");
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);
if(!isParsedM || !isParsedN || !isParsedZ)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}
int countNums = 89;

if (m * n * z > countNums)
{
    Console.Write("Массив слишком большой!");
    return;
}

int[,,] resultNums = Create3DMassive(m, n, z);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNums[i, j, k]} [{i},{j},{k}]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}



