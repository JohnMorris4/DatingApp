using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthResository
    {
         //Register User
         Task<User> Register(User user, string password);

         //Login User
         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}