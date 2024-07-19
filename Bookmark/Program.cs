namespace Bookmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);
            webApplicationBuilder.Services.AddMvc();
            webApplicationBuilder.Services.Configure<WebEncoderOptions>((options) => options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));

            WebApplication webApplication = webApplicationBuilder.Build();
            webApplication.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
            webApplication.UseStaticFiles();

            webApplication.Run();
        }
    }
}
