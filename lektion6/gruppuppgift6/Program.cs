

Console.WriteLine("Add a new bank account.");
Console.WriteLine($"-----------------------------------------");

string? name = null;

while (string.IsNullOrEmpty(name))
{
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Name cannot be empty. Please enter your name.");
    }
}

BankAccount account = new BankAccount(name);

bool exit = false;
while (!exit)
{
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Display account information");
    Console.WriteLine("4. Exit");
    Console.Write("Your choice: ");


    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Console.Write("Choose amount to deposit: ");
            decimal depositAmount;
            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                account.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
            BreakAndReturnToMenu();
            break;

        case "2":
            Console.Clear();
            Console.Write("Choose amount to withdraw: ");
            decimal withdrawAmount;
            if (decimal.TryParse(Console.ReadLine(), out withdrawAmount))
            {
                account.Withdraw(withdrawAmount);
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
            BreakAndReturnToMenu();
            break;

        case "3":
            account.DisplayAccount();
            BreakAndReturnToMenu();
            break;

        case "4":
            exit = true;
            Console.WriteLine("Exiting...");
            break;

        default:
            BreakAndReturnToMenu();
            Console.WriteLine("Invalid choice.");
            break;
    }
}
static void BreakAndReturnToMenu()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}