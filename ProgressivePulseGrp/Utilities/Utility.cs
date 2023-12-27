using ProgressivePulseGrp.Models;
using Microsoft.EntityFrameworkCore;

namespace ProgressivePulseGrp.Utilities
{
    public class Utility
    {
        public static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HatuaGrpDbContext>();
                context.Database.Migrate();
                context.EnsureDatabaseSeeded();
                // context.Database.EnsureCreated();
            }
        }
    }
}
