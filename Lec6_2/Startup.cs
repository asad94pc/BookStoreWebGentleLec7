using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Lec6_2
{
    public class Startup
    {
        public void ConfigrationsServices(IserviceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                await context.Response.WriteAsync("Hellow world this is converted from console to web app"));
            });
        }

    }
}
