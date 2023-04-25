using PizzaMizza.Core.Models.BaseModels;

namespace PizzaMizza.Data.Repositories
{
    public abstract class Repository<T> where T : BaseModel
    {
        private List<T> _items = new List<T>();
        public async Task CreateAsync(T item)
        {
            _items.Add(item);
        }

        public async Task DeleteAsync(T item)
        {
            _items.Remove(item);
        }

        public async Task<T> GetByIdAsync(int id, Predicate<T> func)
        {
            return _items.Find(func);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return _items;
        }
    }
}
