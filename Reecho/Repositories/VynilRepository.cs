using Reecho.Data;

namespace Reecho.Repositories;

public class VynilRepository(PostgreeDbContext context) : IVynilRepository
{
    public async Task<List<Vynil>> GetAllVynils()
    {
        return await context.Vynils.ToListAsync();
    }

    public async Task<Vynil> GetVynilById(int id)
    {
        return await context.Vynils.SingleOrDefaultAsync(x => x.Id == id) ?? throw new InvalidOperationException();
    }

    public async Task CreateVynil(Vynil vynil)
    {
        await context.Vynils.AddAsync(vynil);
        await context.SaveChangesAsync();
    }

    public async Task UpdateVynil(Vynil vynil)
    {
        await context.Vynils.Where(x => x.Id == vynil.Id).ExecuteUpdateAsync(x => 
            x.SetProperty(x => x.Title, vynil.Title)
                .SetProperty(x => x.Genre, vynil.Genre)
                .SetProperty(x => x.Quantity, vynil.Quantity)
                .SetProperty(x => x.Price, vynil.Price)
            );
    }

    public async Task DeleteVynil(int id)
    {
        await context.Vynils.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}