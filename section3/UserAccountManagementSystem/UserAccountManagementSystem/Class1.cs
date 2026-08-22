using System;
using System.Reflection.Metadata.Ecma335;

public class UserAccount
{
    private string _password;
    private decimal _balance;

    public string AccountId { get; init; }

    public string Username { get; set; }

    public string Password { set { _password = "[ENCRYPTED]_" + value; } }

    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0) _balance = value;
            else Console.WriteLine("Error: Balance cannot be negative!");
        }
    }

    public bool IsVIP => Balance >= 10000m;
    public DateTime CreatedDate { get; }

    // Constructor
    public UserAccount()
    {
        // TODO: Initialize CreatedDate here
        CreatedDate = DateTime.Now;
    }
}

