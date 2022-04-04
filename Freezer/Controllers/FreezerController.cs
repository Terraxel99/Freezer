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

        [HttpGet]
        public async Task<IEnumerable<FreezerViewModel>> GetAll()
            => this.mapper.Map<IEnumerable<FreezerViewModel>>(await this.freezerService.GetAllAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<FreezerViewModel>> GetById(Guid id)
        {
            var freezer = this.mapper.Map<FreezerViewModel>(await this.freezerService.GetByIdAsync(id));

            if (freezer is null)
                return this.NotFound();

            return freezer;
        }

        [HttpPost]
        public async Task Create(FreezerCreateViewModel freezer)
            => await this.freezerService.CreateAsync(this.mapper.Map<Core.Models.Freezer>(freezer));

        [HttpPut]
        public Task Update(FreezerViewModel freezer)
            => throw new NotImplementedException("Work in progress.");

        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(Guid id)
            => await this.freezerService.DeleteAsync(id);
    }
}
