int num = int.Parse(Console.ReadLine());

for (int A = 1; A <= 9; A++)
{
    for (int B = 0; B <= 9; B++)
    {
        for (int C = 0; C <= 9; C++)
        {
            for (int D = 0; D <= 9; D++)
            {


                if (A + B == C + D && num == A + B)
                {

                    Console.Write($"{A}{B}{C}{D} ");
                }
            }
        }
    }

}