namespace HotelProject.DataAccessLayer
{
    using Concretes.EntityFramework.Contexts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<MsDbContext>
    {
        //Bu class'in olusturulma nedeni; eger projemizdeki migration islemlerini entity framework
        //cli (powershell vb.) kullanarak yapmak ve hata almak istemezsek diye olusturuyoruz.

        #region Implementation of IDesignTimeDbContextFactory<out MsDbContext>

        public MsDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MsDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }

        #endregion
    }
}
