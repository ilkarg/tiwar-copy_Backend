using Microsoft.AspNetCore.Mvc;
using tiwar_copy_Backend.Data;
using tiwar_copy_Backend.Models;

namespace tiwar_copy_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WriteDataController : Controller
    {
        [HttpPost]
        [Route("WriteAllPlayerData")]
        public bool WriteAllPlayerData([FromBody] Account user) 
        {
            Account? userObject;

            using (AppDBContent db = new AppDBContent())
            {
                userObject = db.Account.ToList().FirstOrDefault(a => a.Login == user.Login && a.Password == user.Password);

                if (userObject != null) 
                {
                    if (userObject.Level != user.Level)
                        userObject.Level = user.Level;

                    if (userObject.Exp != user.Exp)
                        userObject.Exp = user.Exp;

                    if (userObject.Balance != user.Balance)
                        userObject.Balance = user.Balance;

                    if (userObject.Attack != user.Attack)
                        userObject.Attack = user.Attack;

                    if (userObject.Weapon != user.Weapon)
                        userObject.Weapon = user.Weapon;

                    if (userObject.Quest1 != user.Quest1)
                        userObject.Quest1 = user.Quest1;

                    if (userObject.Quest2 != user.Quest2)
                        userObject.Quest2 = user.Quest2;

                    if (userObject.Quest3 != user.Quest3)
                        userObject.Quest3 = user.Quest3;

                    if (userObject.Quest4 != user.Quest4)
                        userObject.Quest4 = user.Quest4;

                    if (userObject.Quest5 != user.Quest5)
                        userObject.Quest5 = user.Quest5;

                    if (userObject.Quest6 != user.Quest6)
                        userObject.Quest6 = user.Quest6;

                    if (userObject.Weapon1_Buying != user.Weapon1_Buying)
                        userObject.Weapon1_Buying = user.Weapon1_Buying;

                    if (userObject.Weapon2_Buying != user.Weapon2_Buying)
                        userObject.Weapon2_Buying = user.Weapon2_Buying;

                    db.SaveChanges();
                }
                else
                    return false;
            }

            return true;
        }
    }
}
