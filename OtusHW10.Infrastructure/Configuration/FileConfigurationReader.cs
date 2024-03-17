using Microsoft.Extensions.Configuration;

namespace OtusHW10.Infrastructure.Configuration
{
    ///<inheritdoc/>
    public class FileConfigurationReader : IConfigurationReader
    {
        ///<inheritdoc/>
        public GameConfig GetGameConfig()
        {
            var builder = new ConfigurationBuilder()
                 .AddJsonFile($"appsettings.json", true, true);

            var config = builder.Build();

            var gameConfig = config.GetSection(nameof(GameConfig))
                .Get<GameConfig>();

            return gameConfig;
        }
    }
}
