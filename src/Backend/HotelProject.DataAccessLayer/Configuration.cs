namespace HotelProject.DataAccessLayer
{
    using Microsoft.Extensions.Configuration;

    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HotelProject.WebApi"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("MsSQL");
            }
        }
    }
}
