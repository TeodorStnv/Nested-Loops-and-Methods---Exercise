
string text = Console.ReadLine();

Console.WriteLine(VowelsCount(text));

static int VowelsCount(string text4e)
{
    int count = 0;
    for (int position = 0; position <= text4e.Length - 1; position++)
    {
        char symbol = text4e[position];

        if (symbol == 'A' || symbol == 'a' ||
        symbol == 'E' || symbol == 'e' ||
        symbol == 'I' || symbol == 'i' ||
        symbol == 'U' || symbol == 'u' ||
        symbol == 'O' || symbol == 'o')
        {
            count += 1;
        }

    }
    return count;
}