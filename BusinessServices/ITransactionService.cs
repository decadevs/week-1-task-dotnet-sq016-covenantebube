using MyBankApp.Models;

namespace MyBankApp.BusinessLogic
{
    public interface ITransactionService
    {
        bool CreateTransaction(BankTransaction bankTransaction);


        BankTransaction? GetTransactionByAccountId(int id);


        List<BankTransaction>? GetAllTransactionByBankAccountId(int bankAccountId);
        
    }
}