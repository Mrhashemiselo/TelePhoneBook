using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class TelePhoneContext: DbContext
    {
        public TelePhoneContext(DbContextOptions<TelePhoneContext> options) : base(options) 
        {
        }

        public DbSet<Domain.Models.Contacts> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
