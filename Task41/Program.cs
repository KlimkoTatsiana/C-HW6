// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArr = RandomArray(length);
PrintArray(newArr);
Console.WriteLine(FindMoreZero(newArr));

int FindMoreZero(int[] arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
        Console.WriteLine("Введите число");
         arr[i] = Convert.ToInt32(Console.ReadLine());
     }
     return arr;
}

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    } 
    Console.WriteLine();
}
