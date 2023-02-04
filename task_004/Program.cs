// на вход принимает одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int P = -N;
while(P <= N)
    {
        Console.Write(P + " ");
        P++;
    }
