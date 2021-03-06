namespace LoanWebApp.DerivedModels
{
    /// <summary>
    /// Class for operation list view
    /// </summary>
    public class OperationGetDto
    {
        public int Id { get; set; }

        public string OperationTypeName { get; set; }

        public decimal Amount { get; set; }

        public string PersonFromFullName { get; set; }

        public string PersonToFullName { get; set; }
    }

    /// <summary>
    /// Class for incoming POST Operation requests
    /// </summary>
    public class OperationPostDto
    {

        public int OperationTypeId { get; set; }

        public decimal Amount { get; set; }

        public int PersonFromId { get; set; }

        public int PersonToId { get; set; }
    }
}