namespace All_Components_Testing_PROD.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>?> GetEmployees();
    }
}