using System.ComponentModel.DataAnnotations;

namespace InertiaDemo.Backend.Requests;

public class SaveContactRequest
{
    public string Name { get; set; } = null!;

    public string Message { get; set; } = null!;
}