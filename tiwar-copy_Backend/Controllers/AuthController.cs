using Microsoft.AspNetCore.Mvc;
using tiwar_copy_Backend.Data;
using tiwar_copy_Backend.Models;

namespace tiwar_copy_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("Auth")]
        public Account? Auth([FromBody] string[] user)
        {
            Account? accountObject;

            using (AppDBContent db = new AppDBContent()) 
            {
                accountObject = db.Account.ToList().FirstOrDefault(a => a.Login == user[0] && a.Password == user[1]);
            }

            return accountObject;
        }

        [HttpPost]
        [Route("Registration")]
        public bool Registration([FromBody] Account user)
        {
            Account? accountObject;

            using (AppDBContent db = new AppDBContent()) 
            {
                accountObject = db.Account.ToList().FirstOrDefault(a => a.Login == user.Login);

                if (accountObject == null)
                {
                    db.Account.AddRange(user);
                    db.SaveChanges();
                }
                else
                    return false;
            }

            return true;
        }
    }
}
