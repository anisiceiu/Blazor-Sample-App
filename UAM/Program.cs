using UAM.Components;
using UAM.DAL;
using UAM.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace UAM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddAuthentication();
            builder.Services.AddAuthentication();
            builder.Services.AddControllers();
            builder.Services.AddHttpClient("myclient", c =>
            {
                c.BaseAddress = new Uri("https://localhost:44348/");
            });

            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
               .Build();

            builder.Services.AddDbContext<DataAppsContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("ConnectionDataApps")));

            builder.Services.AddTransient<IHose21mFittingVolumeServices, Hose21mFittingVolumeServices>();
            builder.Services.AddTransient<ITbl_Rev_per_MaterialServices, Tbl_Rev_per_MaterialServices>();
            builder.Services.AddHttpContextAccessor();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();           
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAntiforgery();
            

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();
            app.MapControllers();

            app.Run();
        }
    }
}
