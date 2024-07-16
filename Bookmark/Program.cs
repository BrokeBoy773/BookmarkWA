namespace Bookmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);
            webApplicationBuilder.Services.AddMvc();

            WebApplication webApplication = webApplicationBuilder.Build();
            webApplication.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
            webApplication.UseStaticFiles();

            webApplication.Run();
        }
    }
}
