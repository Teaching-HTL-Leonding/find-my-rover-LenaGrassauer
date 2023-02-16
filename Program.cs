Console.Clear();
int countEastWest = 0;
int countNorthSouth = 0;
bool CorrectInput = true;
string input = "";

do
{
    System.Console.Write("Please enter your directions: ");
    input = System.Console.ReadLine()!;
    string help = input.Replace("<", "").Replace(">", "").Replace("^", "").Replace("V", "");
    if (help != string.Empty)
    {
        System.Console.Write("Sorry, it seems like you are to gaistig to enter a valid input you hurensohn try again: ");
        input = Console.ReadLine()!;
        CorrectInput = false;
    }
    else {CorrectInput = true;}
} while (CorrectInput == false);


for (int i = 0; i < input.Length; i++)
{
    char direction = input[i];
    switch (direction)
    {
        case 'v': countNorthSouth--; break;
        case '^': countNorthSouth++; break;
        case '<': countEastWest--; break;
        case '>': countEastWest++; break;
    }
}

if (countNorthSouth < 0)
{
    countNorthSouth *= -1;
    System.Console.WriteLine($"{countNorthSouth}m south ");
}
else if (countEastWest < 0)
{
    countEastWest *= -1;
    System.Console.WriteLine($"{countEastWest}m west ");
}
if (countNorthSouth > 0)
{
    System.Console.WriteLine($"{countNorthSouth}m north ");
}
else if (countEastWest > 0)
{
    System.Console.WriteLine($"{countEastWest}m east ");
}

