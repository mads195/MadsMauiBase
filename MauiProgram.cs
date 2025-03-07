﻿using CommunityToolkit.Maui;
using MadsMauiBase.Services.Utilities;
using MadsMauiBase.ViewModels.Examples;
using MadsMauiBase.Views.Examples;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

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

            return oMauiAppBuilderZ;
        }

        public static void RegisterRoutes()
        {
            Routing.RegisterRoute("clipboard", typeof(ClipboardView));
            Routing.RegisterRoute("home", typeof(HomeView));
        }
    }
}
