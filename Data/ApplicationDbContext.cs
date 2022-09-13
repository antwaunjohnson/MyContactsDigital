using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyContactsDigital.Models;

namespace MyContactsDigital.Data;
public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; } = default!;
    public virtual DbSet<Category> Categories { get; set; } = default!;
}
