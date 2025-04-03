namespace Domain;

public interface ISerializerService
{
    public Task SerializeVynil(Vynil vynil);
    public Task<List<Vynil>> DeserializeVynils();
}