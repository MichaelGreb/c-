// выводит на экран числа от одного до 100
// вместо чисел кратных 3 выводится слово Fizz
// 5 - Buzz
// и 3 и 5, то FizzBuzz

Console.Clear();
int count = 1;
while(count<=100)
{
    if((count % 3 == 0) & (count % 5 == 0))
    {
        Console.WriteLine(" FizzBuzz ");
    }
    else if(count % 3 == 0)
    {
        Console.Write(" Fizz ");
    }
    else if(count % 5 == 0)
    {
        Console.Write(" Buzz ");
    }
    else
    {
        Console.Write(count + " ");
    }
    count++;
}


