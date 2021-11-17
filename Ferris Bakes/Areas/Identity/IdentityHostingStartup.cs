using System;
using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Ferris_Bakes.Areas.Identity.IdentityHostingStartup))]
namespace Ferris_Bakes.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserContext")));

                services.AddDefaultIdentity<UserModel>()
                    .AddEntityFrameworkStores<UserContext>().AddDefaultTokenProviders().AddDefaultUI();
            });

        }
    }
}