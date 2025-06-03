using Microsoft.EntityFrameworkCore;

namespace Employee.Api.Model
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options):base(options){


        }

        public DbSet<EmployeeData> EmployeeData { get; set; }
    }
}
