int num = int.Parse(Console.ReadLine());

for (int A = 1; A <= 9; A++)
{
    for (int B = 1; B <= 9; B++)
    {
        for (int C = 1; C <= 9; C++)
        {
            if (A * C * B == num)
            {
                Console.Write($"{A}{B}{C} ");
            }
        }
    }

}