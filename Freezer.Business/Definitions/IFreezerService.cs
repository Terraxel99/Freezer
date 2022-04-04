namespace Freezer.Business.Definitions
{
    using Core.Models;

    public interface IFreezerService
    {
        public Task<IEnumerable<Freezer>> GetAllAsync();
        public Task<Freezer> GetByIdAsync(Guid id);
        public Task CreateAsync(Freezer freezer);
        public Task DeleteAsync(Guid id);
    }
}
