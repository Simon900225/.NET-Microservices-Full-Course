using System.ComponentModel.DataAnnotations;

namespace PlaformService.Models;

public class Platform
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = String.Empty;

    [Required]
    public string Publisher { get; set; } = String.Empty;

    [Required]
    public string Cost { get; set; } = String.Empty;
}