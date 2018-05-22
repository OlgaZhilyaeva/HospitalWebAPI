using HospitalWebApi.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalWebApi
{
    public class Startup
    {
        //public void Configure(IApplicationBuilder app)
        //{
        //    app.UseMvc();
        //}

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // string con = "Server=tcp:sqlservergbwzgnae3bigc.database.windows.net,1433;Initial Catalog=RedisCacheTestDB;Persist Security Info=False;User ID=HelgaAdmin;Password=Kolibri35124;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string con = "Server=tcp:hlp.database.windows.net,1433;Initial Catalog=hlp-database;Persist Security Info=False;User ID=Helga;Password=HeaLTHprOjEct2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string con = "Server=(localdb)\\mssqllocaldb;Database=HospitalDbStore;Trusted_Connection=True;MultipleActiveResultSets=true";
            //string con = "Server=(LocalDb)\\MSSQLLocalDB;Database=HospitalDbStore;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(con));
            services.AddMvc();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // IMPORTANT: This session call MUST go before UseMvc()
            app.UseSession();
            app.UseMvc();

        }
    }
}
