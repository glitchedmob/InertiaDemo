using TypeGen.Core.TypeAnnotations;

namespace InertiaDemo.Backend.Dto;

[ExportTsInterface]
public class HomeDto
{
    public string Title { get; set; } = null!;
}
