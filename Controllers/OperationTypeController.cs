using System.Collections.Generic;
using System.Linq;
using LoanWebApp.DataAccess;
using LoanWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoanWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class OperationTypeController
    {
        private readonly AppDbContext _appDbContext;

        public OperationTypeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IEnumerable<OperationType> GetOperationTypes()
        {
            return _appDbContext.OperationType.ToList();
        }
    }
}