namespace Freezer.Site.Controllers
{
    using Freezer.Business.Definitions;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Site.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class FreezerController : ControllerBase
    {
        private readonly IFreezerService freezerService;

        public FreezerController(IFreezerService freezerService)
            => this.freezerService = freezerService;

        public IEnumerable<FreezerViewModel> GetAll()
        {
            var freezers = this.freezerService.GetAll();

            return Enumerable.Empty<FreezerViewModel>();
        }
    }
}
