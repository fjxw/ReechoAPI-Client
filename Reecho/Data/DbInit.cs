using System;
using Extensions.Hosting.AsyncInitialization;

namespace Reecho.Data;

public class DbInit(PostgreeDbContext postgreeDbContext) : IAsyncInitializer
{
    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        await postgreeDbContext.Database.MigrateAsync(cancellationToken);
    }
}
