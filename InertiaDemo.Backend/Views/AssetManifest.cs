using System.Text.Json;
using System.Text.Json.Serialization;

namespace InertiaDemo.Backend.Views;

public static class AssetManifest
{
    private static ManifestFile? _manifest;


    public static IApplicationBuilder UseAssetManifest(this IApplicationBuilder app)
    {
        var environment = app.ApplicationServices.GetService<IWebHostEnvironment>();

        if (environment is null)
        {
            return app;
        }

        try
        {
            using var fileStream = File.OpenRead(Path.Combine(environment.WebRootPath, "asset-manifest.json"));
            _manifest = JsonSerializer.Deserialize<ManifestFile>(fileStream);
        }
        catch (FileNotFoundException)
        {
        }

        return app;
    }

    private class ManifestFile
    {
        [JsonPropertyName("files")]
        public Dictionary<string, string>? Files { get; set; }
        
        [JsonPropertyName("entrypoints")]
        public List<string>? Entrypoints { get; set; }
    }

    public static string GetPath(string file) => _manifest?.Files?[file] ?? file;
}