//1

// System.Console.WriteLine("Write two words separated by a space");

// string? input = System.Console.ReadLine();

// if (input != null)
// {
//     string[] words = input.ToLower().Split(" ");
//     string pascalCase = "";

//     foreach (string word in words)
//     {
//         if (!string.IsNullOrEmpty(word))
//         {
//             pascalCase += char.ToUpper(word[0]) + word.Substring(1);
//         }
//         else
//         {
//             System.Console.WriteLine("You haven't entered any words");
//         }
//     }

//     System.Console.WriteLine(pascalCase);
// }
// else
// {
//     Console.WriteLine("You haven't entered any words");
// }


//2

// System.Console.WriteLine("Enter your name");
// string? name = System.Console.ReadLine();
// string reversedName = "";

// if (name != null)
// {
//     for (int i = name.Length - 1; i >= 0; i--)
//     {
//         reversedName += name[i];
//     }

//     Console.WriteLine(reversedName);
// }

// 3. Skriv ut namn och antal

string[] names = new string[] {};
bool continueLoop = true;

Console.WriteLine("Enter multiple names, press enter to stop");

while (continueLoop)
{
    string? input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        continueLoop = false;
    }
    else {
        names = names.Append(input).ToArray();
    }
}

if (names.Length == 1){
    Console.WriteLine($"{names[0]}");
}
else if (names.Length == 2){
    Console.WriteLine($"{names[0]}, {names[1]}");
}
else if (names.Length > 2){
    Console.WriteLine($"{names[0]}, {names[1]} and {names.Length - 2} more");
}