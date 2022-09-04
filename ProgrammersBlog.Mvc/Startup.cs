using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgrammersBlog.Services.AutoMapper.Profiles;
using ProgrammersBlog.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages(); //Kursta buras� yok!
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddJsonOptions(opt =>  //MVC Uygulamas� olarak �al��mas�n� s�yler. AddRazorRuntimeCompilation sayesin de front-end taraf�n da anl�k olarak de�i�iklikleri g�rebilece�iz.
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            }); 
            services.LoadMyServices(); //Art�k uygulama aya�a kalk�nca burada �a��rd���m�z merhodlar �a��r�lacakt�r.
            services.AddAutoMapper(typeof(CategoryProfile),typeof(ArticleProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();//Sitemiz de olmayan bir view'a gitmek istedi�imiz de 404 not found gelecektir.
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); //resim dosyalar�,css dosyalar�,hs dosyalar� 

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute( //Birden fazla Area kullan�lacaksa MapControllerRoute i�erisin de tan�mlamamm�z gerekir.
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapDefaultControllerRoute(); //Varsay�lan olarak home controller ve Index'e gidecektir.
            });
        }
    }
}
