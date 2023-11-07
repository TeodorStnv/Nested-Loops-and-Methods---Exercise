int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double finalResul = FactorialFirstNUm(num1) / FactorialSecondNUm(num2);

Console.WriteLine(finalResul);

static double FactorialFirstNUm(int num)
{
    double result = 1;
    for(int i = 1; i <= num; i++)
    {
       result= result *  i;
    }
    return result;
}
static double FactorialSecondNUm(int num)
{
   double result2 = 1;
    for (int i = 1; i <= num; i++)
    {
        result2 = result2 * i;
    }
    return result2;

}