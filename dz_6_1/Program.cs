/* Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] FillDataArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Clear();
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
int FindCountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;

}

Console.Clear();
Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
array = FillDataArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Вы ввели {FindCountNum(array)} числа больше нуля.");