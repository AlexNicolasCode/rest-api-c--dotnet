using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class SaveProductDto
{
    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [Required]
    [Range(0.01, 10000.00)]
    public required float Price { get; set; }
}
