using JQueryDatatableDateFormatAndCurrencySymbolMvc_Demo.Models;
using System.Data.Entity;

namespace JQueryDatatableDateFormatAndCurrencySymbolMvc_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EmployeeDB")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}