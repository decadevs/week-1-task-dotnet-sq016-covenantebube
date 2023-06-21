using MyBankApp.Models;

namespace MyBankApp.BusinessLogic
{
    public interface ICustomerService
    {
        bool CreateCustomer(CustomerAccount customer);

        CustomerAccount? GetCustomerByEmailAndPassword(string email, string password);


        bool AccountCheck(string email, string password);


        CustomerAccount? GetCustomerById(int id);
        
    }
}