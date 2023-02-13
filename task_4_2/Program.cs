// Принимает число и выдает количество цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;
while(num>9)
{
    num=num/10;
    count=count+1;
}
Console.WriteLine($"количество цифр = {count} ");
