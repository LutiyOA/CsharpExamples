void fillArray(int[] array)
{
    int index = 0;

    while (index < array.Length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void printArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
    Console.WriteLine();
}

int findPos(int[] array, int find)
{
    int result = -1;
    int index = 0;
    while (index < array.Length)
    {
        if (array[index] == find)
        {
            result = index; 
            break;
        }
        index++;
    }
    return result;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7 };

//fillArray(array);
printArray(array);
Console.WriteLine($"Значение 2 находится на {findPos(array, 2)} позиции");

int[] array2 = new int[10];
fillArray(array2);
printArray(array2);
int res = findPos(array2, 4);
if (res != -1) Console.WriteLine($"Позиция значения {array2[res]} = {res}");
else Console.WriteLine($"искомое значение в массиве не обнаружено");