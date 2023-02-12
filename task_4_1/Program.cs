// Задача 24: принимает число А и выдает сумму чисел от 1 до А.

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма циифр = {GemSumNums(num)} ");

int GemSumNums(int number)
{
    int sum = 0;
    while(number>0)
        {
            sum += number;
            number--;
        }
    return sum;
}
