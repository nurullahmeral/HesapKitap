using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hesapkitap.business.Abstract;
using hesapkitap.business.concrete;
using hesapkitap.data.Abstract;
using hesapkitap.data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HesapKitap
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHomeRepository,EfCoreHomeRepository>();
            services.AddScoped<IHomeService,HomeManager>();

            services.AddScoped<IGunSonuKategoriRepository,EfCoreGunSonuKategoriRepository>();
            services.AddScoped<IGunSonuKategoriService,GunSonuKategoriManager>();
            
            services.AddScoped<ITransferEkleRepository,EfCoreTransferEkleRepository>();
            services.AddScoped<ITransferEkleService,TransferEkleManager>();

            services.AddScoped<IGiderEkleRepository,EfCoreGiderEkleRepository>();
            services.AddScoped<IGiderEkleService,GiderEkleManager>();

            services.AddScoped<IGunSonuTutarRepository,EfCoreGunSonuTutarRepository>();
            services.AddScoped<IGunSonuTutarService,GunSonuTutarManager>();

            services.AddScoped<ITransferKalemiRepository,EfCoreTransferKalemiRepository>();
            services.AddScoped<ITransferKalemiService,TransferKalemiManager>();

            services.AddScoped<IGiderKategoriRepository,EfCoreGiderKategoriRepository>();
            services.AddScoped<IGiderKategoriService,GiderKategoriManager>();

            services.AddScoped<IUrunKategoriRepository,EfCoreUrunKategoriRepository>();
            services.AddScoped<IUrunKategoriService,UrunKategoriManager>();

            services.AddScoped<ITarihKontrolRepository,EfCoreTarihKontrolRepository>();
            services.AddScoped<ITarihKontrolService,TarihKontrolManager>();

            services.AddScoped<IDegerKisitlaRepository,EfCoreDegerKisitlaRepository>();
            services.AddScoped<IDegerKisitlaService,DegerKisitlaManager>();
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
                   name: "default",
                   pattern:"{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
