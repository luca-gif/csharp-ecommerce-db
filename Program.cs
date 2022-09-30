using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello world!");

using (Ecommerce db = new Ecommerce())
{
    // Create
    Employee employee = new Employee {Name = "Pippo", Surname = "Pappo", Level = 2 };

    //db.Employees.Add(employee);


    // Read
    //foreach(var item in db.Products)
    //{
    //    Console.WriteLine(item.Name);
    //}

    // Update

    /*employee.Surname = "Jack";
    db.SaveChanges();*/

    // Remove

    /*db.Remove(employee);
    db.SaveChanges();*/

    Product milk = db.Products.Where(milk => milk.Name == "latte").First();
    Console.WriteLine(milk.Name);
}

public class Ecommerce : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ecommerce-db;Integrated Security=True");
    }

}


