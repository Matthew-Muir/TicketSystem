using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Data;

[assembly: HostingStartup(typeof(TicketSystem.Areas.Identity.IdentityHostingStartup))]
namespace TicketSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TicketSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TicketSystemContextConnection")));

                services.AddDefaultIdentity<TicketSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TicketSystemContext>();
            });
        }
    }
}