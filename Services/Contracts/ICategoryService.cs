using Entities.Models;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync(bool trackChanges);
        Task<Category> GetOneCategoryByIdAsync(int id, bool trackChanges); 
    }
}
