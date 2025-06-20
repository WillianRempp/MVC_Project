using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.Client;

public class Client
{
    public int Id { get; set; }

    [Required] public string Name { get; set; } = string.Empty;

    [EmailAddress] public string Email { get; set; } = string.Empty;
}