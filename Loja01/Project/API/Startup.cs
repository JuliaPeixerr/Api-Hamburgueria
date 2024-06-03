using Loja01.Project.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Loja01.Project.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Data Source=app.db";
            services.AddDbContext<ProjectContext>(options => options.UseSqlite(connectionString));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // Outros serviços da aplicação
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Configurações de rota
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            // Executa as migrações do banco de dados
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ProjectContext>();
                dbContext.Database.Migrate();
            }
        }
    }
}
