using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeManagementSystemApi.Data;
using OfficeManagementSystemApi.Models;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OfficeManagementSystemApi.Repositorys;

public class MyRepo : IMyRepo
{
    MyDbContext _dbContext;

    public MyRepo(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<object>> AllImployeesSaleryOver12000()
    {
        var data = _dbContext.Employees
            .Select(e => new
            {
                EmployeeId = e.Id,
                EmployeeName = e.Name,
                Salary = e.Salary
            })
            .Where(e => e.Salary > 12000);
        return await data.ToListAsync();
    }


    public async Task<IEnumerable<object>> EmployeeDepartment()
    {
        var data = _dbContext.Employees
            .Select(e => new
            {
                employeeId = e.Id,
                employeeName = e.Name,
                departmentName = e.Department.Name,
                location = e.Department.Location
            });

        return await data.ToListAsync();
    }
    public async Task<IEnumerable<object>> ProjectsByBudget()
    {
        var data = _dbContext.Projects
            .Select(p => new
            {
                projectId = p.Id,
                projectName = p.Name,
                budget = p.Budget,
                departmentName = p.Department.Name
            })
            .OrderByDescending(p => p.budget);
        return await data.ToListAsync();
    }

    public async Task<IEnumerable<object>> DepartmentsWorkersSalaryAvg()
    {
        var data = _dbContext.Departments
            .Select(d => new
            {
                DepartmentId = d.Id,
                DepartmentName = d.Name,
                EmployeeCount = d.Employees.Count,
                AverageSalary = d.Employees.Average(e => e.Salary)
            });
        return await data.ToListAsync();
    }
    public async Task<IEnumerable<object>> DepartmentStatistics()
    {
        var data = _dbContext.Departments
           .Select(d => new
           {
               DepartmentId = d.Id,
               DepartmentName = d.Name,
               EmployeeCount = d.Employees.Count,
               AverageSalary = d.Employees.Average(e => e.Salary),
               TotalProjectBudget = d.Projects.Sum(p => p.Budget)
           });
        return await data.ToListAsync();
    }


    public async Task<IEnumerable<object>> FilterByAvgSalery()
    {
        var data = _dbContext.Departments
           .Select(d => new
           {
               DepartmentId = d.Id,
               DepartmentName = d.Name,
               AverageSalary = d.Employees.Average(e => e.Salary)
           })
           .Where(d => d.AverageSalary >= 13000);
        return await data.ToListAsync();
    }
    public async Task<IEnumerable<object>> OrderByTotalBudget()
    {
        var data = _dbContext.Departments
           .Select(d => new
           {
               DepartmentID = d.Id,
               DepartmentName = d.Name,
               NumberOfProjects = d.Projects.Count,
               TotalProjectBudget = d.Projects.Sum(p => p.Budget),
               AverageProjectBudget = d.Projects.Average(p => p.Budget)
           })
           .OrderByDescending(d => d.TotalProjectBudget);

        return await data.ToListAsync();
    }


}

