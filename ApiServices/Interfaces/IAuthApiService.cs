using System.Threading.Tasks;
using BlogFront.Models;

namespace BlogFront.ApiServices.Interfaces{
    public interface IAuthApiService{
        Task<bool> SignIn(AppUserLoginModel model);
    }
}