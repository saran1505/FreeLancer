using FreeLance.Model;
using Microsoft.EntityFrameworkCore;

namespace FreeLance.DBContext
{
    public class FreelanceDbContext : DbContext
    {
        public FreelanceDbContext(DbContextOptions<FreelanceDbContext> options) : base(options) { }

        public DbSet<FreelanceUser> FreelanceUsers { get; set; }
        public DbSet<USkillset> USkillsets { get; set; }
        public DbSet<UHobby> UHobbies { get; set; }
    }
}
