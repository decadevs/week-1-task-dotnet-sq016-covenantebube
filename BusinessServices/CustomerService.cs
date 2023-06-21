using MyBankApp.Models;
using MyBankApp.repository;

namespace MyBankApp.BusinessLogic
{
    public class CustomerService: ICustomerService
    {
        private IRepository _repository;
        public IRepository repository
        {
            get => _repository ??= new repository.repository();
        }
        public bool CreateCustomer(CustomerAccount customer)
        {
            return repository.CreateCustomer(customer);
        }
        public CustomerAccount? GetCustomerByEmailAndPassword(string email, string password)
        {
            return repository.GetCustomerByEmailAndPassword(email, password);
        }

        public bool AccountCheck(string email, string password)
        {
           return repository.AccountCheck(email, password);
        }

        public CustomerAccount? GetCustomerById(int id)
        {
            return repository.GetCustomerById(id);
        } 
    }
}
