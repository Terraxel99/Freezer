namespace Freezer.Data.Definitions
{
    using Core.Models;

    public interface IFreezerRepository
    {
        public IEnumerable<Freezer> GetAll();
        public Freezer GetById(Guid id);
        public int Create(Freezer freezer);
        public void DeleteById(Guid id);
    }
}
