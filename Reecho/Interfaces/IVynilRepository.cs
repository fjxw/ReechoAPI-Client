namespace Domain;

public interface IVynilRepository
{
     public Task<List<Vynil>> GetAllVynils();
     public Task<Vynil> GetVynilById(int id);
     public Task CreateVynil(Vynil vynil);
     public Task UpdateVynil(Vynil vynil);
     public Task DeleteVynil(int id);
}