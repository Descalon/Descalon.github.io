using Devlead.Statiq.Themes;

return await Bootstrapper
    .Factory
    .CreateDefault(args)
    .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/archive/refs/heads/main.zip"))
    .AddWeb()
    .RunAsync();

