//using Classes;
//using System.Security.Principal;
//using ReadAndWrite;



////var account = new BankAccount("<Marco>", 1000);
////Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance");

//// account.MakeWithdrawal(500, DateTime.Now, "Pokemon payment");
////Console.WriteLine(account.Balance);
////account.MakeDeposit(700, DateTime.Now, "Job payment");
////Console.WriteLine(account.Balance);

//Console.WriteLine("What would you like to do?");
//Console.WriteLine("a - Create a new account");
//Console.WriteLine("b - Login into your account");
//// Zwischen Speicher
//string Owner1;
//decimal Balance1;
//decimal Amount1;
//string Note1;
//bool PasswortOk = false;
//// Limitierung 12 Zeichen min / max
//int PinCode1;


////Random random = new Random();
//// Cases
//switch (Console.ReadLine())
//{
//    case "a":

//        Console.WriteLine("What would the Owners Account name be");
//        Owner1 = Console.ReadLine();
//        Console.WriteLine("How much is your initial Balance");
//        Balance1 = Convert.ToInt32(Console.ReadLine());
//        var account = new BankAccount(Owner1, Balance1);
//        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance");
//        break;
//    case "b":
//        Console.WriteLine("Enter Your Account Number");
//        Owner1 = Console.ReadLine();
//        Console.WriteLine("Enter Your Passwort");
//        PinCode1 = Convert.ToInt32(Console.ReadLine());
//        // Check for login correkt
        

        
 
     
//        break;
//}
//if (PasswortOk == true)
//{
//    Console.WriteLine("a - Deposit something into your account");
//    Console.WriteLine("b - Withdraw something from your account");
//}



//// Login
//// Console.WriteLine("How much would you like to Deposit");
////Amount1 = Convert.ToInt32(Console.ReadLine());
//////Console.WriteLine("Reason for Deposit");
////Note1 = Console.ReadLine();
////account.MakeDeposit(Amount1, DateTime.Now, Note1);
////Console.WriteLine(account.Balance);


//// DatenBank für Account Speicherung 
//// PW Login Accounts
//// Cases für Neu erstellung oder Login
//// Cases Einzahlung Auszahlung Balance



//// Invalid Bank Acc
////BankAccount invalidAccount;
////try
////{
////  invalidAccount = new BankAccount("<Flare>", -34);
////}
////catch (ArgumentOutOfRangeException e)
////{
////  Console.Write Line("Exception Caught Creating Account with negative value");
////Console.WriteLine(e.ToString());
////return;
////}

////Console.WriteLine(account.GetAccountHistory()); 
