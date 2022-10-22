using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace ATM.Classes;

// Definiert Klasse
public class BankAccount
{
    // Eigenschaften 
    public string Number { get; }
    public int PinCode { get; set; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }
<<<<<<< HEAD


=======
    
    public class Atm
    {
        string filePath = @"C:\atm\test.txt";

        List<string> lines = new List<string>();
        

        public void NewAccountAdd(string Number, int PinCode, string Owner, decimal Balance)
        {
            string s = " ,";
            string input = (Number + s + PinCode + s + Owner + s + Balance).ToString();
            lines.Add(input);
            File.WriteAllLines(filePath, lines);
        }

        public void LoginAccount(string Number, int PinCode)
        {
            foreach (string line in lines)
            {
                string[] arr = line.Split(',');
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == Number)
                    {
                        if (arr[j + 2] == PinCode.ToString())
                        {
                            Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Number or PinCode");
                        }
                    }
                }



            }

        }
    }
>>>>>>> 5bfc07d8663ea8643b85cd3781192f0bf24d6595


    // Number Generator ID
    public string NumG()
    {
        string Num = Convert.ToString(Guid.NewGuid());
        return Num;
    }

    // Methoden

    public BankAccount(string name,int pincode, decimal initialBalance)
    {
        Number = NumG();
        PinCode = pincode;
        Owner = name;
        MakeDeposit(initialBalance);
    }

    // Transaktionen Dekleration
    private List<Transaction> allTransactions = new List<Transaction>();

    //
    public void MakeDeposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount);
        allTransactions.Add(deposit);
    }
    public void MakeWithdrawal(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawel must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount);
        allTransactions.Add(withdrawal);
    }

    // History Konten
    //public string GetAccountHistory()
    //{
    //    var report = new System.Text.StringBuilder();

    //    decimal balance = 0;
    //    report.AppendLine($"Date\t\tAmount\tBalance\tNote");
    //    foreach (var item in allTransactions)
    //    {
    //        balance += item.Amount;
    //        report.AppendLine($"{item.Amount}\t{balance}");
    //    }
    //    return report.ToString();
    //}


}


