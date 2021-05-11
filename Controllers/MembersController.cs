using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using familycoins.Models;
using familycoins.Data;

namespace familycoins.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly FamilyCoinsDbContext _context;
        private readonly ILogger<MembersController> _logger;

        public MembersController(ILogger<MembersController> logger, FamilyCoinsDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<FamilyMember> GetMembers()
        {
            return _context.FamilyMembers;
        }
    }
}
