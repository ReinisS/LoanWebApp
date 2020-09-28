using System.Collections.Generic;
using System.Linq;
using LoanWebApp.DataAccess;
using LoanWebApp.DerivedModels;
using LoanWebApp.Models;
using LoanWebApp.Utils;
using Microsoft.AspNetCore.Mvc;
using static LoanWebApp.Models.OperationType;

namespace LoanWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class OperationController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public OperationController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Gets operation data for list view
        /// </summary>
        /// <returns>List of operation data</returns>
        [HttpGet]
        public IEnumerable<OperationGetDto> GetOperations()
        {
            return _appDbContext.Operation.Select(o => new OperationGetDto
            {
                Id = o.Id,
                OperationTypeName = o.OperationType.Name,
                Amount = o.Amount,
                PersonFromFullName = NameHelper.GetFullName(o.PersonFrom.FirstName, o.PersonFrom.OtherNames, o.PersonFrom.LastName),
                PersonToFullName = NameHelper.GetFullName(o.PersonTo.FirstName, o.PersonTo.OtherNames, o.PersonTo.LastName)
            }
            ).ToList();
        }

        /// <summary>
        /// Saves an operation to database
        /// </summary>
        /// <param name="operation">POST operation data</param>
        [HttpPost]
        [Consumes("application/json")]
        public void PostOperation([FromBody] OperationPostDto operation)
        {
            _appDbContext.Operation.Add(new Operation
            {
                OperationType = _appDbContext.OperationType.Find((OperationTypeId)operation.OperationTypeId),
                Amount = operation.Amount,
                PersonFrom = _appDbContext.Person.Find(operation.PersonFromId),
                PersonTo = _appDbContext.Person.Find(operation.PersonToId)
            });
            _appDbContext.SaveChanges();
        }
    }
}