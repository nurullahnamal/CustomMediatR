using System.Collections.Generic;
using System.Threading.Tasks;
using CustomMediatR.Api.Command;
using CustomMediatR.Api.Query;
using CustomMediatR.Library.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomMediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator mediator;

        public TestController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public Task<int> Get()
        {
            //return mediator.Send(new GetUserByIdQuery(10));

            return mediator.Send(new UpdateNameCommand("Yusuf"));

        }
    }
}
