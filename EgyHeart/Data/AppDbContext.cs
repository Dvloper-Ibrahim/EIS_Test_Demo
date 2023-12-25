using EgyHeart.Models.M_Medical;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public  DbSet<ClinicTran> ClinicTrans { get; set; }

        public  DbSet<Pat> Pats { get; set; }

        public  DbSet<PatAdmission> PatAdmissions { get; set; }
        



    }
}
