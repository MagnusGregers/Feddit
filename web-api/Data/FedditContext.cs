using shared.Model;
using Microsoft.EntityFrameworkCore;


namespace web_api.Data;

public class FedditContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Comment> Comments => Set<Comment>();
    
    public FedditContext(DbContextOptions<FedditContext> options)
        :base(options)
    {}
    
}