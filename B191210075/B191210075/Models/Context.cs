using Microsoft.EntityFrameworkCore;

namespace ECommerceSite.Models
{
    public class Context: DbContext
    {
        //tanımlanan tum modelleri buraya tanımlar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-QORO4PVD\\SQLEXPRESS; database=CoreECommerceSite;integrated security=true;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;"); 
            //base.OnConfiguring(optionsBuilder);
        }
        public DbSet<ProductCategoryViewModel>? ProductCategory { get; set; }
    }
}
