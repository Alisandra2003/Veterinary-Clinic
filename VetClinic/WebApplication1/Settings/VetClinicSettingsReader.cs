namespace VetClinic.WebAPI.Settings
{
    public class VetClinicSettingsReader
    {
        public static VetClinicSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new VetClinicSettings();
        }
    }
}
