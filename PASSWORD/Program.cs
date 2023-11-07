using System;

string password = Console.ReadLine();

//· "Password must be between 6 and 10 characters"

//· "Password must consist only of letters and digits"

//· "Password must have at least 2 digits"
bool password6to10 = CountOfChars(password);
bool lettersAndDigits = TypeOfChars(password);
bool twoDigits = MinimumDigits(password);

if(password6to10 == false)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if(lettersAndDigits == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (twoDigits == false)
{
    Console.WriteLine("Password must have at least 2 digits");
}
 if(password6to10== true && lettersAndDigits == true && twoDigits == true)
{
    Console.WriteLine("Password is valid");
}

static bool CountOfChars(string password)
{
    if(password.Length <6 || password.Length > 10)
    {
        return false;
    }
    return true;
}

static bool TypeOfChars(string password)
{
    for (int i = 0; i < password.Length; i++)
    {
        char symbol = password[i];
        
        if(char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    } 
    return true;
}

static bool MinimumDigits (string password)
{
    int count = 0;
    for (int i = 0; i<password.Length; i++) 
    { 
        char symbol = password[i];
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }
    if (count >= 2)
    {
        return true;
    }
    return false;
}
