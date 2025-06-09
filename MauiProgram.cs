using CommunityToolkit.Maui;
using MadsMauiBase.Controls.StarterKit;
using MadsMauiBase.Services.Utilities;
using MadsMauiBase.ViewModels.Examples;
using MadsMauiBase.ViewModels.StarterKit;
using MadsMauiBase.Views.Examples;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Mads195.MadsMauiLib;

namespace MadsMauiBase
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var oBuilderZ = MauiApp.CreateBuilder();
            oBuilderZ
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                .UseMadsMauiLib()
                // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterServices()
                .RegisterViewModels();

            RegisterRoutes();

#if DEBUG
            oBuilderZ.Logging.AddDebug();
#endif

            return oBuilderZ.Build();
        }

        /// <summary>
        /// Register services
        /// </summary>
        /// <param name="oMauiAppBuilderZ"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder oMauiAppBuilderZ)
        {
            oMauiAppBuilderZ.Services.AddSingleton<IClipboardService, ClipboardService>();
            oMauiAppBuilderZ.Services.AddTransientPopup<MadsPopup, MadsPopupViewModel>();

            return oMauiAppBuilderZ;
        }

        /// <summary>
        /// Register view models
        /// </summary>
        /// <param name="oMauiAppBuilderZ"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder oMauiAppBuilderZ)
        {
            oMauiAppBuilderZ.Services.AddTransient<ClipboardView>();
            oMauiAppBuilderZ.Services.AddTransient<ClipboardViewModel>();
            oMauiAppBuilderZ.Services.AddTransient<HomeView>();
            oMauiAppBuilderZ.Services.AddTransient<HomeViewModel>();
            oMauiAppBuilderZ.Services.AddTransient<FormView>();
            oMauiAppBuilderZ.Services.AddTransient<FormViewModel>();
            oMauiAppBuilderZ.Services.AddTransient<PopupView>();
            oMauiAppBuilderZ.Services.AddTransient<PopupViewModel>();

            return oMauiAppBuilderZ;
        }

        public static void RegisterRoutes()
        {
            Routing.RegisterRoute("clipboard", typeof(ClipboardView));
            Routing.RegisterRoute("home", typeof(HomeView));
            Routing.RegisterRoute("form", typeof(FormView));
            Routing.RegisterRoute("popupviewmodel", typeof(PopupView));
        }
    }
}
