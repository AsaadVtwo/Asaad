using System.Threading.Tasks;
using Vega.API.Models;

namespace Vega.API.Repository
{
  public interface IAuthRepository
  {
    Task<User> Register (User user, string password);
    Task<User> Login (string username, string password);
    Task<bool> UserExists (string username);
  }
}