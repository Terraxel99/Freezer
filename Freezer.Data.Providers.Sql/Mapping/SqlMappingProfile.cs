namespace Freezer.Data.Providers.Sql.Mapping
{
    using AutoMapper;

    using Data.Providers.Sql.Models;

    public class SqlMappingProfile : Profile
    {
        public SqlMappingProfile()
        {
            this.CreateMap<Freezer, Core.Models.Freezer>();
        }
    }
}
