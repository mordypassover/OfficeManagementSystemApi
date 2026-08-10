namespace OfficeManagementSystemApi.Repositorys
{
    public interface IMyRepo
    {
        Task<IEnumerable<object>> AllImployeesSaleryOver12000();
        Task<IEnumerable<object>> EmployeeDepartment();
        Task<IEnumerable<object>> ProjectsByBudget();
        Task<IEnumerable<object>> DepartmentsWorkersSalaryAvg();
        Task<IEnumerable<object>> DepartmentStatistics();
        Task<IEnumerable<object>> FilterByAvgSalery();
        Task<IEnumerable<object>> OrderByTotalBudget();
    }

}
