namespace Freezer.Site.Controllers
{
    using AutoMapper;

    using Freezer.Business.Definitions;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Site.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class FreezerController : ControllerBase
    {
        private readonly IFreezerService freezerService;
        private readonly IMapper mapper;

        public FreezerController(IFreezerService freezerService, IMapper mapper)
        {
            this.freezerService = freezerService ?? throw new ArgumentNullException(nameof(freezerService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IEnumerable<FreezerViewModel> GetAll()
            => this.mapper.Map<IEnumerable<FreezerViewModel>>(this.freezerService.GetAll());
    }
}
