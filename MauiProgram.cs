using Microsoft.Extensions.Logging;

namespace TaskManager
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
#endif

            // Register services with the dependency injection container
            //builder.Services.AddSingleton<TodoListPage>();
            builder.Services.AddTransient<TodoItemPage>();
            builder.Services.AddSingleton<TodoItemDatabase>();

            return builder.Build();
        }
    }
}

