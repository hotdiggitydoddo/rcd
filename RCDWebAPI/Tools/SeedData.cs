using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RCDWebAPI.Data
{
    public static class SampleData
    {

        public static async Task InitializePostDatabaseAsync(IServiceProvider serviceProvider, bool createUsers = true)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<RCDContext>();
                await db.Database.EnsureDeletedAsync();

                await db.Database.EnsureCreatedAsync();
                // if (await db.Database.EnsureCreatedAsync())
                // {
                //     await InsertTestData(serviceProvider);
                // }
            }
        }
    }
}