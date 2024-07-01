using Microsoft.Extensions.Logging;
using s5fchamorro.Utils;

namespace s5fchamorro
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            
            
#if DEBUG
    		builder.Logging.AddDebug();
            string dbPath = FileAccessHelper.getLocalFilePath("personas.db3");
            builder.Services.AddSingleton<PersonRepository>(s => ActivatorUtilities.CreateInstance<PersonRepository>(s,dbPath));
#endif

            return builder.Build();
        }
    }
}
