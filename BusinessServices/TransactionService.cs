using MyBankApp.Models;
using MyBankApp.repository;

namespace MyBankApp.BusinessLogic
{
    public class TransactionService: ITransactionService
    {
        private IRepository _repository;
        public IRepository repository
        {
            get => _repository ??= new repository.repository();
        }
        public bool CreateTransaction(BankTransaction bankTransaction)
        {
            return repository.CreateTransaction(bankTransaction);
        }

        public BankTransaction? GetTransactionByAccountId(int id)
        {
            return GetTransactionByAccountId(id);
        }

        public List<BankTransaction>? GetAllTransactionByBankAccountId(int bankAccountId)
        {
            return repository.GetAllTransactionByBankAccountId(bankAccountId);
        }
    }
}
