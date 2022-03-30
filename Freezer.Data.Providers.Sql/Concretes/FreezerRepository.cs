namespace Freezer.Data.Providers.Sql.Concretes
{
    using System;
    using System.Collections.Generic;
    
    using AutoMapper;

    using Data.Definitions;
    
    using Freezer.Core.Models;
    
    public class FreezerRepository : IFreezerRepository
    {
        private readonly FreezerDbContext db;
        private readonly IMapper mapper;

        public FreezerRepository(FreezerDbContext db, IMapper mapper)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public int Create(Freezer freezer)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Freezer> GetAll()
            => this.mapper.Map<IEnumerable<Core.Models.Freezer>>(this.db.Freezers.ToList());

        public Freezer GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
