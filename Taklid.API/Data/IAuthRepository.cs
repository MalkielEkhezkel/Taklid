using System.Threading.Tasks;
using Taklid.API.Models;

namespace Taklid.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string userName, string password);
         Task<bool> UserExists(string userName);

    }
}