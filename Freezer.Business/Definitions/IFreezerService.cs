namespace Freezer.Business.Definitions
{
    using Core.Models;

    public interface IFreezerService
    {
        public IEnumerable<Freezer> GetAll();
    }
}
