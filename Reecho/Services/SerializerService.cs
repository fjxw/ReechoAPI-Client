using System.Text.Json;
using System.IO;

namespace Reecho.Services;

public class SerializerService : ISerializerService
{
    private string path = "Json/Vynils.json";
    public async Task SerializeVynil(Vynil vynil)
    {
        var vynils = File.Exists(path)
            ? JsonSerializer.Deserialize<List<Vynil>>(await File.ReadAllTextAsync(path)) ?? []
            : [];
        vynils.Add(vynil);
        await File.WriteAllTextAsync(path, JsonSerializer.Serialize(vynils));
    }

    public async Task<List<Vynil>> DeserializeVynils()
    {
        var vynils = File.Exists(path) 
            ? JsonSerializer.Deserialize<List<Vynil>>(await File.ReadAllTextAsync(path)) ?? []
            : [];
        return vynils;
    }
}

