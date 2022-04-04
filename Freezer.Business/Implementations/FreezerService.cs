namespace Freezer.Business.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Business.Definitions;

    using Freezer.Core.Models;
    using Freezer.Data.Definitions;

    public class FreezerService : IFreezerService
    {
        public readonly IFreezerRepository freezerRepository;

        public FreezerService(IFreezerRepository freezerRepository)
            => this.freezerRepository = freezerRepository;

        public async Task CreateAsync(Freezer freezer)
            => await this.freezerRepository.CreateAsync(freezer);

        public async Task DeleteAsync(Guid id)
        {
            // TODO : Check if there are items in the freezer. 
            // If yes, try delete those before deleting the actual freezer.

            await this.freezerRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Freezer>> GetAllAsync()
            => await this.freezerRepository.GetAllAsync();

        public async Task<Freezer> GetByIdAsync(Guid id)
            => await this.freezerRepository.GetByIdAsync(id);
    }
}
