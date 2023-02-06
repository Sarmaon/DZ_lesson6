// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
foreach (int v in array)
{
    if (v <= 0)
    {
        continue;
    }
    count++;
}

Console.WriteLine(value: $"Колличество введеных чисел {count}");