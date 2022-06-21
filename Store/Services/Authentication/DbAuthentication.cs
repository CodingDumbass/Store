using Store.Data;
using Store.Models;

namespace Store.Services.Authentication
{
    public class DbAuthentication
    {
        private shop_dbContext dbService = new shop_dbContext();

        public bool Authenticate(CustomerModel user)
        {
            return dbService.FindByUser(user);
        }
        public bool AuthenticateEmail(CustomerModel user)
        {
            return dbService.InsertUser(user);
        }
    }
}
