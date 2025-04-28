using Microsoft.EntityFrameworkCore;

namespace BulkyWEB.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    {
        
    }
}