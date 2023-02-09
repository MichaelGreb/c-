// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y)

Console.Clear();
Console.Write("Введите номер четверти: ");
int chetv = int.Parse(Console.ReadLine());
if (chetv > 4 || chetv < 1)
{
    Console.WriteLine("Error 404");
} 
else
{
    if (chetv == 1)
    {
        Console.WriteLine("x>0,y>0");
    }
    if (chetv == 2)
    {
        Console.WriteLine("x<0,y>0");
    }
    if (chetv == 3)
    {
        Console.WriteLine("x<0,y<0");
    }
    if (chetv == 4)
    {
        Console.WriteLine("x>0,y<0");
    }


}