using System.Threading.Tasks;

namespace BlogFront.ApiServices.Interfaces{
    
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}