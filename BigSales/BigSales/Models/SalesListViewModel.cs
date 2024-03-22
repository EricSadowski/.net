namespace BigSales.Models
{
    public class SalesListViewModel
    {
        public List<Sales> Sales { get; set; } = null!;
        public List<Employee> Employees { get; set; } = null!;
        public int EmployeeId { get; set; }
    }
}
