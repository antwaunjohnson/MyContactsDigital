using MyContactsDigital.Data;
using Microsoft.EntityFrameworkCore;

namespace MyContactsDigital.Helpers;

public static class DataHelper
{
    public static async Task ManageDataAsync(IServiceProvider svcProvider)
    {
        var dbContextsvc = svcProvider.GetRequiredService<ApplicationDbContext>();
        await dbContextsvc.Database.MigrateAsync();
    }
}
