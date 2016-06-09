using Microsoft.EntityFrameworkCore;
 namespace RCDWebAPI
 {
     public class RCDContext : DbContext
     {
         private RCDContext() { }

         public RCDContext(DbContextOptions<RCDContext> options)
            : base(options) { }

         public DbSet<Post> Posts {get; set;}

     }
 }