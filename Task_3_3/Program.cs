// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве

Console.Clear();
Console.Write("Введите координаты X1: ");
long x1 = long.Parse(Console.ReadLine());
Console.Write("Введите координаты Y1: ");
long y1 = long.Parse(Console.ReadLine());
Console.Write("Введите координаты X2: ");
long x2 = long.Parse(Console.ReadLine());
Console.Write("Введите координаты Y2: ");
long y2 = long.Parse(Console.ReadLine());
long lenght;
if((x1>0) && (x2>0))
    {
        if(x1>x2)
        {
            lenght=x1-x2;
        }
        else
        {
            lenght=x2-x1;
        }
    }
else if((x1<0)  && (x2<0))
    {
        if(x1>x2)
        {
            lenght=x2-x1;
        }
        else
        {
            lenght=x1-x2;
        }
    }
else
{
    if(x1>x2)
    {
        lenght=x1-x2;
    }
    else 
    {
        lenght=x2 - x1;
    }
}
long width;
if((y1>0) && (y2>0))
{
    if(y1>y2)
    {
        width=y1-y2;
    }
    else
    {
        width=y2-y1;
    }
}
else if((y1<0) && (y2<0))
    {
        if(y1>y2)
        {
            width=y2-y1;
        }
        else
        {
            width=y1-y2;
        }
    }
else
{
    if(y1>y2)
    {
        width=y1-y2;
    }
    else
{
    width=y2-y1;
}
}
double result = Math.Sqrt(lenght*lenght + width*width);
Console.WriteLine($"Растояние между точками {result}");