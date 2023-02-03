// Программа принимает два числа и проверяет, является ли первое квадратом второго

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
//int sqr = number2*number2;
if(number1 == number2*number2)
    {
        Console.Write(number1 + " является квадратом " + number2);
    }
    else
    {
        Console.Write(number1 + " не является квадратом " + number2);
    }
