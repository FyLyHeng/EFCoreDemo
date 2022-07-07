namespace EFCoreDI.Domain.Entity
{
    public class Invoice : BaseEntity
    {
        public String? InvoiceNo { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
