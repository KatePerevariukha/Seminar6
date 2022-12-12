// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());;
int[] array = new int[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
        {
        if (array[i]>0)
        count++;
        }
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество чисел больше нуля: {count}");