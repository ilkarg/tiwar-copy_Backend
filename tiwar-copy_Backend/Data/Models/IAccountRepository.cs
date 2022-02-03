using tiwar_copy_Backend.Models;

namespace tiwar_copy_Backend.Data.Models
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account Get(int id);
        Account GetByLogin(string login);
        Account Add(Account item);
        void Remove(int id);
        bool Update(Account item);
    }
}
