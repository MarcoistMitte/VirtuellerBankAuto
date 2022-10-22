using ATM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Menu
    {
        public void MenuAn()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a - Create a new account");
            Console.WriteLine("b - Login into your account");

            // Zwischen Speicher
            string Owner1;
            decimal Balance1;
            decimal Amount1;
            bool PasswortOk = false;
            // Limitierung 12 Zeichen min / max
            int PinCode1;
            string Line = "";


            switch (Console.ReadLine())
            {
                case "a":

                    Console.WriteLine("What would the Owners Account name be");
                    Owner1 = Console.ReadLine();
                    Console.WriteLine("Enter a Pincode");
                    PinCode1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How much is your initial Balance");
                    Balance1 = Convert.ToInt32(Console.ReadLine());
                    while (Balance1 <= 0)
                    {
                        Console.WriteLine("Balance cant be 0 or lower.");
                        Balance1 = Convert.ToInt32(Console.ReadLine());
                    }
                    var account = new BankAccount(Owner1,PinCode1, Balance1);
                    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance");

                    //  For Writing New Account into Txt
                    NewAcc creater = new NewAcc();
                    creater.AccAdd(account.Number, PinCode1, account.Owner, account.Balance);
                    break;
                case "b":
                    Console.WriteLine("Enter Your Account Number");
                    Owner1 = Console.ReadLine();
                    Console.WriteLine("Enter Your Passwort");
                    PinCode1 = Convert.ToInt32(Console.ReadLine());
                    // Check for login correkt
                    Atm check = new Atm();
                    PasswortOk = check.LoginAccount(Owner1,PinCode1);

                    Atm change = new Atm();
                    Line = change.Account(Owner1, PinCode1);



                    break;
            }
            
            if (PasswortOk == true)
            {
                // Values of the Account
                string [] AccV = Line.Split(',');



                Console.WriteLine("a - Deposit something into your account");
                Console.WriteLine("b - Withdraw something from your account");
                
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine("Enter Amount");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        var account = new BankAccount("<Marco>", 1421, 1000);
                        account.MakeDeposit(amount);
                        break;
                    case "b":
                        break;

                }
            }
            else
            {
                Console.WriteLine("Wrong PW");
            }
        }
        
    }
}
