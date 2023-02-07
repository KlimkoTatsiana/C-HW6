// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


int b1 = new Random().Next(0, 9);
int b2 = new Random().Next(0, 9);
int k1 = new Random().Next(0, 9);
int k2 = new Random().Next(0, 9);

void IntersectionPoint(int b1, int b2, int k1, int k2)
{
int y = 0;
int x = 0;
x = (b2 - b1) / (k2 - k1);
y = k1 * x + b1;
Console.WriteLine($"({x},{y})");
}

IntersectionPoint(b1, b2, k1, k2);