using Devlead.Statiq.Themes;
using Statiq.Web;

return await Bootstrapper
    .Factory
    .CreateDefault(args)
    .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/archive/refs/heads/main.zip"))
    .AddWeb()
    .DeployToGitHubPages("descalon","descalon.github.io", Config.FromSetting<string>("GITHUB_TOKEN"))
    .RunAsync();

