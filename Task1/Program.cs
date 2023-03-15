// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int sizeArray = size;
int minValue = min;
int maxValue = max;
int[] resultArray = RandArray(sizeArray, minValue, maxValue);

int[] RandArray(int size, int min, int max)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
Console.WriteLine ($"[{String.Join("; ", resultArray)}]");
int count = 0;
for (int i = 0; i < resultArray.Length; i++)
{
    if(resultArray[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля {count}");