namespace Asp.net.mvc.Task6.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanySystemTask7 : DbContext
    {
        public CompanySystemTask7()
            : base("name=CompanySystemTask7")
        {
        }
        

         public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
    
}