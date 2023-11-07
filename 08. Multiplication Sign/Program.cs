static void MultiplicationSigna(int num1, int num2, int num3)
{
    if (num1 < 0 && num2 > 0 && num3 > 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 < 0 && num2 < 0 && num3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 < 0 && num2 > 0 && num3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 < 0 && num2 < 0 && num3 < 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 > 0 && num2 > 0 && num3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 > 0 && num2 < 0 && num3 > 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 > 0 && num2 < 0 && num3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 > 0 && num2 > 0 && num3 < 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("zero");
    }
}


int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

MultiplicationSigna(number1, number2, number3);


