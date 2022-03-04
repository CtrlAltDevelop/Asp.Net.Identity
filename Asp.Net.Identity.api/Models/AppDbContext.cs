using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net.Identity.api.Models;

public class AppDbContext : IdentityDbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
}

