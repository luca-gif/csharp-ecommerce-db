
using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


public class Ecommerce : DbContext
{
    public DbSet <Product> Products { get; set; }
    public DbSet <Payment> Payments { get; set; }
    public DbSet <Employee> Employees { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet <Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ecommerce-db;Integrated Security=True");
    }

}