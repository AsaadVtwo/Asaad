using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.api.Models;
using Vega.api.Data;
using Vega.api.Resources;

namespace Vega.api.Controllers {

    [Route ("api/[controller]")]
    public class MakesController : Controller {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public MakesController (VegaDbContext context, IMapper mapper) {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Make>> GetMakes () {

            var makes = await context.Makes
                .Include (m => m.Models)
                .ToListAsync ();

            // return mapper.Map<List<Make>,List<MakeResource>>(makes);
            return (makes);
        }

    }
}