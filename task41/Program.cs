// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое количество чисел хотите проверить? ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполните массив числами: ");
int count = 0;
int[] arr = new int[M];
for (int i = 0; i < M; i++)
{
    arr [i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Ваш массив: "+'[' + string.Join("," , arr) + ']');
Console.WriteLine("Количество чисел больше 0 равно: " + count);