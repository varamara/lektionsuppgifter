public class BankAccount
{
    private int _accountNumber { get; set; }
    private string? _name { get; set; }
    private decimal _balance { get; set; }


    public BankAccount(string name)
    {
        _accountNumber = GenerateAccountNumber();
        _name = name;
        _balance = 0;
    }

    private int GenerateAccountNumber()
    {
        Random random = new Random();
        return random.Next(100000000, 199999999);
    }

    public void CreateAccount()
    {
        Console.WriteLine("Enter your Name: ");
        string? newName = Console.ReadLine();
    }

    public void DisplayAccount()
    {
        Console.Clear();
        Console.WriteLine($"Your Account Information");
        Console.WriteLine($"-----------------------------------------");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Account Number: {_accountNumber}");
        Console.WriteLine($"Balance: {_balance}");
        Console.WriteLine($"-----------------------------------------");
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}");
            DisplayAccount();
        }
        else
        {
            Console.WriteLine("Amount must be greater than 0");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
                DisplayAccount();
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Amount must be greater than 0");
        }
    }
}