using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace familycoins.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : ControllerBase
    {
        private static readonly FamilyMember[] Members = new[]
        {
            new FamilyMember() { Id=0, Name="Eric", Details = "", FamilyCoinsScore = 500 },
            new FamilyMember() { Id=1, Name="Adri", Details = "", FamilyCoinsScore = 500 }
        };

        private readonly ILogger<MembersController> _logger;

        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<FamilyMember> GetMembers()
        {
            return Members;
        }
    }
}
