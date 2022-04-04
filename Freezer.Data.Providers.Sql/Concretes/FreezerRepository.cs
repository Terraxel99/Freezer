namespace Freezer.Data.Providers.Sql.Concretes
{
    using System;
    using System.Collections.Generic;
    
    using AutoMapper;

    using Data.Definitions;
    
    using Freezer.Core.Models;
    using Microsoft.EntityFrameworkCore;

    public class FreezerRepository : IFreezerRepository
    {
        private readonly FreezerDbContext db;
        private readonly IMapper mapper;

        public FreezerRepository(FreezerDbContext db, IMapper mapper)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task CreateAsync(Freezer freezer)
        {
            await this.db.Freezers.AddAsync(this.mapper.Map<Models.Freezer>(freezer));
            await this.db.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var freezer = new Models.Freezer { Id = id };
            this.db.Freezers.Attach(freezer);
            this.db.Freezers.Remove(freezer);

            await this.db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Freezer>> GetAllAsync()
            => this.mapper.Map<IEnumerable<Core.Models.Freezer>>(await this.db.Freezers.ToListAsync());

        public async Task<Freezer> GetByIdAsync(Guid id)
            => this.mapper.Map<Freezer>(await this.db.Freezers.SingleOrDefaultAsync(f => f.Id == id));
    }
}
