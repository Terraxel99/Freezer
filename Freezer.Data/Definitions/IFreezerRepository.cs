namespace Freezer.Data.Definitions
{
    using Core.Models;

    public interface IFreezerRepository
    {
        public Task<IEnumerable<Freezer>> GetAllAsync();
        public Task<Freezer> GetByIdAsync(Guid id);
        public Task CreateAsync(Freezer freezer);
        public Task DeleteByIdAsync(Guid id);
    }
}
