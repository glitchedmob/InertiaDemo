using TypeGen.Core.TypeAnnotations;

namespace InertiaDemo.Backend.Dto;

[ExportTsInterface]
public class AboutDto
{
    [TsNull]
    public string? Title { get; set; }
}