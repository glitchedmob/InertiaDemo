using TypeGen.Core.TypeAnnotations;

namespace InertiaDemo.Backend.Dto;

[ExportTsInterface]
public class HomeDto
{
    [TsNull]
    public string? Title { get; set; }
}
