using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<Users> Register(Users user,string password);
         Task<Users> Login(string user,string password);
         Task<bool> UserExists(string userName);
    }
}