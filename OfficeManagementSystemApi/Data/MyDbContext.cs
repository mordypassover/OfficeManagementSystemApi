using Microsoft.EntityFrameworkCore;


namespace OfficeManagementSystemApi.Data;

public class MyDbContext: DbContext
{

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }


}
