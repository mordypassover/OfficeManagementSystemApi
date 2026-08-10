using Microsoft.AspNetCore.Mvc;
using OfficeManagementSystemApi.Repositorys;

namespace OfficeManagementSystemApi.Conrrollers;

[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    IMyRepo _repo;
    public MyController(IMyRepo repo)
    {
        _repo= repo;
    }
    [HttpGet("over-12000/")]
    public async Task<ActionResult<IEnumerable<object>>> AllImployeesSaleryOver12000()
    {
        return Ok(await _repo.AllImployeesSaleryOver12000());
    }

    [HttpGet("employees-departments/")]
    public async Task<ActionResult<IEnumerable<object>>> EmployeeDepartment()
    {
        return Ok(await _repo.EmployeeDepartment());
    }
    [HttpGet("Projects-budgets/")]
    public async Task<ActionResult<IEnumerable<object>>> ProjectsByBudget()
    {
        return Ok(await _repo.ProjectsByBudget());
    }

    [HttpGet("Workers-Salary-Avg")]
    public async Task<ActionResult<IEnumerable<object>>> DepartmentsWorkersSalaryAvg()
    {
        return Ok(await _repo.DepartmentsWorkersSalaryAvg());
    }
    [HttpGet("Departments-Statistics")]
    public async Task<ActionResult<IEnumerable<object>>> DepartmentStatistics()
    {
        return Ok(await _repo.DepartmentStatistics());
    }
    [HttpGet("filter-Salary13000+")]
    public async Task<ActionResult<IEnumerable<object>>> FilterByAvgSalery()
    {
        return Ok(await _repo.FilterByAvgSalery());
    }

    [HttpGet("Departments-by-Budget")]
    public async Task<ActionResult<IEnumerable<object>>> OrderByTotalBudget()
    {
        return Ok(await _repo.OrderByTotalBudget());
    }
}