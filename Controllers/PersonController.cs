using System.Collections.Generic;
using System.Linq;
using LoanWebApp.DataAccess;
using LoanWebApp.DerivedModels;
using LoanWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using static LoanWebApp.Models.OperationType;

namespace LoanWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Gets person details list for person list view
        /// </summary>
        /// <returns>Person details list</returns>
        [HttpGet]
        public IEnumerable<PersonDetails> GetPersons()
        {
            return _appDbContext.Person.Select(p => new PersonDetails()
            {
                Id = p.Id,
                FirstName = p.FirstName,
                OtherNames = p.OtherNames,
                LastName = p.LastName,
                AmountLoanedToOthers =
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Loan && o.PersonFrom == p)
                        .Sum(o => (decimal?) o.Amount) ?? 0 -
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Repayment && o.PersonTo == p)
                        .Sum(o => (decimal?) o.Amount) ?? 0,
                AmountLoanedFromOthers =
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Loan && o.PersonTo == p)
                        .Sum(o => (decimal?) o.Amount) ?? 0 -
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Repayment && o.PersonFrom == p)
                        .Sum(o => (decimal?) o.Amount) ?? 0
            }).ToList();
        }

        [HttpPost]
        [Consumes("application/json")]
        public void PostPerson([FromBody] Person person)
        {
            _appDbContext.Person.Add(person);
            _appDbContext.SaveChanges();
        }
    }
}
