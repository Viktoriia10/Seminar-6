/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введите число M, которое соответствует количеству цифр:");
int Number = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[Number];

void InputNumbers(int Number)
{
    for (int i = 0; i < Number; i++)
    {
        Console.Write($"Введите {i + 1} Number:");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(Number);

Console.WriteLine($"Количество элементов массива больше 0: {Comparison(massiveNumbers)} ");
