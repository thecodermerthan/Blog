using System.Collections.Generic;
using System.Threading.Tasks;
using BlogFront.Models;

namespace BlogFront.ApiServices.Interfaces{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
        Task<List<CategoryWithBlogsCountModel>> GetAllWithBlogsCount();
        Task<CategoryListModel> GetByIdAsync(int id);

    }
}