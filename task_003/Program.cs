// Дни недели
Console.Clear();
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
    {
        Console.Write("понедельник");
    }
if(number == 2)
    {
        Console.Write("вторник");
    }
if(number == 3)
    {
        Console.Write("среда");
    }
if(number == 4)
    {
        Console.Write("четверг");
    }
if(number == 5)
    {
        Console.Write("пятница");
    }
if(number == 6)
    {
        Console.Write("суббота");
    }
if(number == 7)
    {
        Console.Write("воскресенье");
    }
if(number > 7)
    {
        Console.Write("значение неверно");
    }
    if(number < 1)
    {
        Console.Write("значение неверно");
    }