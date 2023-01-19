// SЗадача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
 // 2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine());
int NumberN2 = -NumberN;
int count = NumberN2;
while (count < NumberN +1)
{
    Console.Write(count+" ");
    count = count +1;
}
