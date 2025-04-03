using Microsoft.AspNetCore.Http.HttpResults;

namespace Reecho.Endpoints;

public static class VynilEndpoints
{
    public static void MapVinylEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/vynils")
            .WithTags("Vynils")
            .WithOpenApi();
        
        group.MapGet("/all", GetAllVynils).RequireCors("AllowLocalhost");
        group.MapGet("/{id:int}", GetVynilById);
        group.MapGet("/vynilimg",  GetVynilImage);
        group.MapPost("/", AddVynil);
        group.MapPut("/", UpdateVynil);
        group.MapDelete("/{id:int}", DeleteVynilById);

    }
    
    private static async Task<IResult> GetVynilImage()
    {
        return Results.File("vynil.jpg", "image/jpg", "IMG_VYNIL.jpg");
    }
    
    private static async Task<IResult> GetAllVynils(IVynilRepository repository)
    {
        return Results.Ok(await repository.GetAllVynils());
    }

    private static async Task<IResult> GetVynilById(int id, IVynilRepository repository)
    {
        return Results.Ok(await repository.GetVynilById(id));
    }

    private static async Task<IResult> UpdateVynil(Vynil vynil, IVynilRepository repository)
    {
        await repository.UpdateVynil(vynil);
        return Results.NoContent();
    }
    
    private static async Task<IResult> AddVynil(Vynil vynil, IVynilRepository repository)
    {
        await repository.CreateVynil(vynil);
        return Results.Created($"/api/vynils/{vynil.Id}", vynil);
    }

    private static async Task<IResult> DeleteVynilById(int id, IVynilRepository repository)
    {
        await repository.DeleteVynil(id);
        return Results.NoContent();
    }
}