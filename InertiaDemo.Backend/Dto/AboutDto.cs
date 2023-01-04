using TypeGen.Core.TypeAnnotations;

namespace InertiaDemo.Backend.Dto;

[ExportTsInterface]
public class AboutDto
{
    public string? Title { get; set; }
}