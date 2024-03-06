using Task3;

var account1=new BankAccount(); 
account1.AccountNumber=11100235; 
account1.TopUp(1500); 
account1.Withdraw(320); 
var balance=account1.PrintStatement();
System.Console.WriteLine($"Account {account1.AccountNumber} has {balance} USD in balance");
