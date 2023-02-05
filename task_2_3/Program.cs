// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.


Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите ыторое число: ");
int number2 = int.Parse(Console.ReadLine());
int rem = number2%number1;
if(rem == 0)
{
    Console.Write($"{number2} является кратным {number1}");
}
else
{
     Console.Write($"{number2} не является кратным {number1}. Остаток деления {number2} на {number1} равен {rem}");
}


