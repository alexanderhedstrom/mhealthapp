using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPLab
{
    public interface IAPIConnector
    {
        Task<bool> RegisterUser(User user);
        Task<User> VerifyLogin(User user);
        Task UpdateUser(User user);
        Task UpdateStats(Stats stats);
    }
}
