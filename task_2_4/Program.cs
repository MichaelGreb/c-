// принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int n1 = int.Parse(Console.ReadLine());
if((n1 % 7 == 0) & (n1 % 23 ==0))
{
    Console.WriteLine($"{n1} -> да");
}
else
{
    Console.WriteLine($"{n1} -> нет");
}