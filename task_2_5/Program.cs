// принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.Clear();
Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if((n1 * n1 == n2) || (n2 % n2 == n1))
{
    Console.WriteLine($"{n1},{n2} -> да");
}
else
{
    Console.WriteLine($"{n1},{n2} -> нет");
}


