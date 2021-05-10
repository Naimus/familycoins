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
    public class TransactionsController : ControllerBase
    {
        private static readonly FamilyPointsTransaction[] Transactions = new[]
        {
            new FamilyPointsTransaction() { Id=0, TypeOfTransaction=FamilyPointsTransactionType.FAMILYACTIVITY, Name="No Hacer Caso", Details = "", points = -100 },
            new FamilyPointsTransaction() { Id=1, TypeOfTransaction=FamilyPointsTransactionType.FAMILYACTIVITY, Name="No Hacer Caso 2", Details = "", points = -100 }
        };

        private readonly ILogger<TransactionsController> _logger;

        public TransactionsController(ILogger<TransactionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FamilyPointsTransaction> GetTransactions()
        {
            return Transactions;
        }

    }
}
