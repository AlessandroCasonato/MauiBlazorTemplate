﻿using Microsoft.Extensions.Logging;
using MauiBlazorTemplate.App.Data;
using MauiBlazorTemplate.Services;

namespace MauiBlazorTemplate.App;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IStudentService, StudentService>();
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}