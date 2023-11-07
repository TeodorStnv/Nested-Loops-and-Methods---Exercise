int num = int.Parse(Console.ReadLine());


for (int i = 2; i <= num; i = i + 2)
{

    for (int b = 1; b <= num; b += 2)
    {

        Console.Write($"{i}{b}{i * b} ");
    }
    // Console.Write($"{even}{odd}{even * odd} ");



}