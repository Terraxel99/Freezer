namespace Freezer.Site.Mapping
{
    using AutoMapper;

    using Site.ViewModels;

    public class SiteMappingProfile : Profile
    {
        public SiteMappingProfile()
        {
            this.CreateMap<Core.Models.Freezer, FreezerViewModel>().ReverseMap();
            this.CreateMap<FreezerCreateViewModel, Core.Models.Freezer>();
        }
    }
}
