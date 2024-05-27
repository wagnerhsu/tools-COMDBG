using Microsoft.Extensions.Configuration;

namespace ComDbgCommon
{
    public class ConfigurationUtility
    {
        private IConfiguration _configuration;
        public ConfigurationUtility()
        {
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        }

        public int GetCodePage => _configuration.GetSection("CodePage").Get<int>();
    }
}
