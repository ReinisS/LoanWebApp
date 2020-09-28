using LoanWebApp.Models;
using static LoanWebApp.Models.OperationType;

namespace LoanWebApp.DataAccess
{
    /// <summary>
    /// Data for initial data import
    /// </summary>
    public static class InitialDbData
    {
        public static Person[] InitialPersonList = new Person[5]
        {
            new Person
            {
                Id = 1,
                FirstName = "Jānis",
                LastName = "Bērziņš"
            },
            new Person
            {
                Id = 2,
                FirstName = "Līga",
                LastName = "Ceriņa"
            },
            new Person
            {
                Id = 3,
                FirstName = "Andris",
                OtherNames = "Juris",
                LastName = "Ozols"
            },
            new Person
            {
                Id = 4,
                FirstName = "Anna",
                OtherNames = "Marija",
                LastName = "Vītola"
            },
            new Person
            {
                Id = 5,
                FirstName = "Pēteris",
                LastName = "Osis"
            }
        };

        public static object[] InitialOperationList = new object[20]
        {
            new
            {
                Id = 1,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 1.00m,
                PersonFromId = InitialDbData.InitialPersonList[0].Id,
                PersonToId = InitialDbData.InitialPersonList[1].Id
            },
            new
            {
                Id = 2,
                OperationTypeId = OperationTypeId.Repayment,
                Amount = 1.00m,
                PersonFromId = InitialDbData.InitialPersonList[1].Id,
                PersonToId = InitialDbData.InitialPersonList[0].Id
            },
            new
            {
                Id = 3,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 2.00m,
                PersonFromId = InitialDbData.InitialPersonList[0].Id,
                PersonToId = InitialDbData.InitialPersonList[2].Id
            },
            new
            {
                Id = 4,
                OperationTypeId = OperationTypeId.Repayment,
                Amount = 1.00m,
                PersonFromId = InitialDbData.InitialPersonList[2].Id,
                PersonToId = InitialDbData.InitialPersonList[0].Id
            },
            new
            {
                Id = 5,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 3.00m,
                PersonFromId = InitialDbData.InitialPersonList[1].Id,
                PersonToId = InitialDbData.InitialPersonList[2].Id
            },
            new
            {
                Id = 6,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 4.00m,
                PersonFromId = InitialDbData.InitialPersonList[1].Id,
                PersonToId = InitialDbData.InitialPersonList[2].Id
            },
            new
            {
                Id = 7,
                OperationTypeId = OperationTypeId.Repayment,
                Amount = 20.00m,
                PersonFromId = InitialDbData.InitialPersonList[2].Id,
                PersonToId = InitialDbData.InitialPersonList[1].Id
            },
            new
            {
                Id = 8,
                OperationTypeId = OperationTypeId.Repayment,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[2].Id,
                PersonToId = InitialDbData.InitialPersonList[3].Id
            },
            new
            {
                Id = 9,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[2].Id,
                PersonToId = InitialDbData.InitialPersonList[3].Id
            },
            new
            {
                Id = 10,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 11,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 12,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 13,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 14,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 15,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 16,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 17,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 18,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 19,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            },
            new
            {
                Id = 20,
                OperationTypeId = OperationTypeId.Loan,
                Amount = 5.00m,
                PersonFromId = InitialDbData.InitialPersonList[3].Id,
                PersonToId = InitialDbData.InitialPersonList[4].Id
            }
        };
    }
}