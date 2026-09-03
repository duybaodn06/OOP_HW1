using System.Security.Cryptography;

public class BankAccount
{
    // TODO 1: Declare private fields (_balance, _pin, _failedAttempts)
    private decimal _balance;
    private string _pin;
    private int _failedAttempts;

    // TODO 2: Declare public AccountHolder property (read-only)
    public string AccountHolder { get; init; }

    // TODO 3: Declare IsLocked property with a private setter
    public bool IsLocked { get; private set; }

    // Constructor
    public BankAccount(string accountHolder, decimal initialBalance, string initialPin)
    {
        AccountHolder = accountHolder;
        _balance = initialBalance > 0 ? initialBalance : 0;
        _pin = initialPin;
        _failedAttempts = 0;
        IsLocked = false;
    }

    // TODO 4: Implement Deposit method
    public bool Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposit successful! New balance: {_balance}");
            return true;
        }
        else
        {
            Console.WriteLine("Deposit failed! Amount must be positive.");
            return false;
        }
            
    }

    // TODO 5: Implement Withdraw method
    public bool Withdraw(decimal amount, string inputPin)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal failed! Amount must be positive.");
            return false;
        }
        if (IsLocked)
        {
            Console.WriteLine("Account is locked. Cannot perform withdrawal.");
            return false;
        } 
        if (inputPin != _pin)
        {
            _failedAttempts++;
            if (_failedAttempts >= 3)
            {
                IsLocked = true;
                Console.WriteLine("Account locked due to 3 failed PIN attempts.");
            }
            else Console.WriteLine($"Incorrect PIN. You have {_failedAttempts} failed attempt(s).");
            return false;
        }
        if (_balance - amount < 0)
        {
            Console.WriteLine("Withdrawal failed! Insufficient funds.");
            return false;
        }

        _failedAttempts = 0;
        _balance -= amount;
        Console.WriteLine($"Withdrawal successful! New balance: {_balance}");
        return true;
    }


    // TODO 6: Implement GetBalance method (PIN required)
    public decimal GetBalance(string inputPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Account is locked. Cannot perform withdrawal.");
            return -1m;
        } 
        if (inputPin != _pin)
        {
            _failedAttempts++;
            if (_failedAttempts >= 3)
            {
                IsLocked = true;
                Console.WriteLine("Account locked due to 3 failed PIN attempts.");
            }
            else Console.WriteLine($"Incorrect PIN. You have {_failedAttempts} failed attempt(s).");
            return -1m;
        }
        _failedAttempts = 0;
        return _balance;
    }

    // TODO 7: Implement ChangePin method
    public bool ChangePin(string currentPin, string newPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Account is locked. Cannot perform withdrawal.");
            return false;
        }
        if (currentPin != _pin)
        {
            _failedAttempts++;
            if (_failedAttempts >= 3)
            {
                IsLocked = true;
                Console.WriteLine("Account locked due to 3 failed PIN attempts.");
            }
            else Console.WriteLine($"Incorrect PIN. You have {_failedAttempts} failed attempt(s).");
            return false;
        }
        if (string.IsNullOrWhiteSpace(newPin) || newPin.Length != 4 || !newPin.All(char.IsDigit))
        {
            Console.WriteLine("New PIN must be a 4-digit number.");
            return false;
        }
        _failedAttempts = 0;
        _pin = newPin;
        Console.WriteLine("PIN changed successfully.");
        return true;
    }
}

class Program
{
    static void Main5(string[] args)
    {
        BankAccount account = new BankAccount("John Doe", 500.00m, "1234");

        Console.WriteLine($"Account Holder: {account.AccountHolder}");

        // Direct field access is impossible! (Uncommenting below will cause compiler errors)
        // account._balance = 1000000m; 
        // account._pin = "0000";

        Console.WriteLine("\n--- 1. Testing Deposit ---");
        account.Deposit(-50m); // Should fail
        account.Deposit(200m); // Should succeed
    }
}
