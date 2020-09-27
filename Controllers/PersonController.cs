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
                        .Sum(o => o.Amount) -
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Repayment && o.PersonTo == p)
                        .Sum(o => o.Amount),
                AmountLoanedFromOthers =
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Loan && o.PersonTo == p)
                        .Sum(o => o.Amount) -
                    _appDbContext.Operation
                        .Where(o => o.OperationType.Id == OperationTypeId.Repayment && o.PersonFrom == p)
                        .Sum(o => o.Amount)
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
