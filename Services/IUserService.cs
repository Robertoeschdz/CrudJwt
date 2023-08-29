using CrudJwt.Models;

namespace CrudJwt.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
