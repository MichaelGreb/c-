// Кавдрат заданного числа

Console.Clear();
Console.Write("Введите целое число:");
int Number = int.Parse(Console.ReadLine()); // int.Parse перевод введенного пользователем значения из символного в числовой
int sqr = Number * Number;
Console.WriteLine("Квадрат числа " + Number + " равен = " + sqr);

