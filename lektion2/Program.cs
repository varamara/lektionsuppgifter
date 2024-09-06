//1

Console.WriteLine("How many students are there?");

if (int.TryParse(Console.ReadLine(), out int students))
{
    int passing = 0;
    int failing = 0;

    for (int i = 0; i < students; i++)
    {

        Console.WriteLine("What grade did student " + (i + 1) + " get?");

        if (int.TryParse(Console.ReadLine(), out int grade))
        {

            if (grade >= 3 && grade <= 5)
            {
                passing++;
            }
            else if (grade < 3)
            {
                failing++;
            }
            else
            {
                Console.WriteLine("Invalid grade, please enter a grade between 0 and 5.");
                i--;
                continue;
            }
        }
        else
        {
            Console.WriteLine("Input invalid, please enter a valid number.");
            i--;
        }
    }

    Console.WriteLine("Passing: " + passing + " Failing: " + failing);
}
else
{
    Console.WriteLine("Input invalid, please enter a valid number of students.");
}


//2 


Console.WriteLine("Enter a number to see how many numbers are divisible by 3 from 0 to that number");

if (int.TryParse(Console.ReadLine(), out int numberDivisibleByThree))
{
    int count = 0;

    for (int i = 0; i <= numberDivisibleByThree; i++)
    {
        if (i % 3 == 0)
        {
            count++;
        }
    }

    Console.WriteLine(count);
}
else
{
    Console.WriteLine("Input invalid, please enter a valid number.");
}


//3


int[] numbers = new int[0];
bool continueLoop = true;

Console.WriteLine("Enter a number, write 'avsluta' to stop");

while (continueLoop)
{
    string? input2 = Console.ReadLine();

    if ("avsluta" == input2)
    {
        continueLoop = false;
    }
    else
    {
        if (int.TryParse(input2, out int number))
        {
            numbers = numbers.Append(number).ToArray();
        }
        else
        {
            Console.WriteLine("Input invalid, please enter a valid number.");
        }
    }
}

Console.WriteLine(numbers.Sum());


//4


Console.WriteLine("Enter the height and then width of your image: ");

if (int.TryParse(Console.ReadLine(), out int height) && 
    int.TryParse(Console.ReadLine(), out int width))
{
    if (height < width)
    {
        Console.WriteLine("landscape");
    }
    else if (height > width)
    {
        Console.WriteLine("portrait");
    }
    else if (height == width)
    {
        Console.WriteLine("square");
    }
}
else
{
    Console.WriteLine("Input invalid, please enter a valid number.");
}