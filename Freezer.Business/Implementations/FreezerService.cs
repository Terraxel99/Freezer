namespace Freezer.Business.Implementations
{
    using System.Collections.Generic;
    
    using Business.Definitions;

    using Freezer.Core.Models;
    using Freezer.Data.Definitions;

    public class FreezerService : IFreezerService
    {
        public readonly IFreezerRepository freezerRepository;

        public FreezerService(IFreezerRepository freezerRepository)
            => this.freezerRepository = freezerRepository;

        public IEnumerable<Freezer> GetAll()
            => this.freezerRepository.GetAll();
    }
}
