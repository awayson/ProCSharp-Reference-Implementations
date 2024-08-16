using StaticDataAndMembers;

Console.WriteLine("**** Fun with Static Data ****\n");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);

// Access static field
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
// New instance Instantiation does NOT 'reset' the value of the static field
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();

Console.ReadLine();