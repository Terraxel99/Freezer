namespace Freezer.Data.Providers.Sql.Concretes
{
    using System;
    using System.Collections.Generic;

    using Data.Definitions;
    
    using Freezer.Core.Models;
    
    public class FreezerRepository : IFreezerRepository
    {
        private readonly FreezerDbContext db;

        public FreezerRepository(FreezerDbContext db)
            => this.db = db ?? throw new ArgumentNullException(nameof(db));

        public int Create(Freezer freezer)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Freezer> GetAll()
        {
            return this.db.Freezers
                .Select(f => new Freezer
                {
                    Id = f.Id,
                    Name = f.Name,
                });
        }

        public Freezer GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
