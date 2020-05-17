using System.Collections.Generic;
using Microservices.Transfer.Application.Interfaces;
using Microservices.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService transferService;

        public TransferController(ITransferService transferService)
        {
            this.transferService = transferService;
        }

        // Get api/banking
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(transferService.GetTransferLogs());
        }
    }
}
