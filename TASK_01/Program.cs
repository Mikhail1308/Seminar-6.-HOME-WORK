// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел (M): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbersM = new int[m];

void InputNumber(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumbersM[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountToPositivNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

InputNumber(m);
Console.WriteLine($"Введено чисел > 0:  {CountToPositivNumber(arrayNumbersM)} ");
Console.WriteLine();