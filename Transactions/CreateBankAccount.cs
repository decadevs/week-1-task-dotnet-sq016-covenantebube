using MyBankApp.BusinessLogic;
using MyBankApp.Models;

namespace MyBankApp.Transactions
{
    public class CreateBankAccount
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }
        public static void CreateNewAccount(CustomerAccount customer)
        {
            Console.Clear();
            Console.WriteLine("Choose account type");
            Console.WriteLine("Select 1 for current account");
            Console.WriteLine("Select 2 for savings account");
            string? accountType = Console.ReadLine();

            if (accountType != "1" && accountType != "2")
            {
                Console.Clear();
                Console.WriteLine("Invalid input, please choose between 1 and 2");
                CreateBankAccount.CreateNewAccount(customer);
            }
            else
            {
                Random random = new();
                string accountNum = Convert.ToString(random.Next(1011111111, 1099999999));
                BankAccount bankAcc = new(customer.Id, accountNum, accountType == "1" ? AccountType.CurrentAccount : AccountType.SavingsAccount);
                bankAccountService.CreateBankAccount(bankAcc);
               

                Console.WriteLine("Please make initial deposit");
                Console.WriteLine("How much do you wish to deposit? ");
                decimal amountToDeposit = decimal.Parse(Console.ReadLine());
                while (amountToDeposit <= 1000)
                {
                    Console.Clear();
                    Console.WriteLine("Please deposit a minimum value of 1000!.How much do you wish to deposit? ");
                    amountToDeposit = decimal.Parse(Console.ReadLine());
                }
                bankAccountService.Deposit(amountToDeposit, bankAcc, "Initial Deposit");
                Utility.PressEnterToContinue();
                Console.Clear();
                Console.WriteLine("Congratulations, Your bank account has been created!");
                Console.WriteLine($"Your account number is {accountNum}");
                Console.WriteLine("Do you want to perform another transaction? ");
                TransactionMenu.TransactionOptions(customer);
            }


        }
    }
}
