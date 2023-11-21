namespace VetClinic.WebAPI.Settings
{
    public class VetClinicSettingsReader
    {
        public static VetClinicSettings Read(IConfiguration configuration)
        {
            return new VetClinicSettings()
            {
                VetClinicDbContextConnectionString = configuration.GetValue<string>("VetClinicDbContext")
            };
        }
    }
}
