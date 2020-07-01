using Microsoft.EntityFrameworkCore;
namespace Test.Models
{
    public class ApplictionDbContext:DbContext
    {
        public ApplictionDbContext (){}
        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite("Filename=./PartyInvites.db");
        }

        public DbSet<GuestResponse> Invites{get;set;}
    }
}