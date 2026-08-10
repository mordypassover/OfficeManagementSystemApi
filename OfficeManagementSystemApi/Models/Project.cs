namespace OfficeManagementSystemApi.Models;

public class Project
{
    public int Id { get; set; }
    public int DepartmentId {  get; set; }
    public string Name { get; set; }
    public int Budget { get; set; }

    public Department Department { get; set; }
}
