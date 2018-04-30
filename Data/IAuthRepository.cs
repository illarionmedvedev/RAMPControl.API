using System.Threading.Tasks;
using RAMPControl.API.Models;

namespace RAMPControl.API.Data
{
    public interface IAuthRepository
    {
         Task <User> Register (User user, string password);
         Task <User> Login (string username, string password);
         Task <bool> UserExists (string username);
    }
}