using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDispatch.SharedModels.Entities;

[Table("units")]
public class Unit
{
    [Key]
    [Required]
    [Column("id")]
    [MaxLength(20)]
    public required string Id { get; set; }

    [Column("record_id")]
    [MaxLength(255)]
    public Guid RecordId { get; set; }

    [Column("type")]
    [Required]
    public required int Type { get; set; } 

    [Column("status")]
    [Required]
    public required int Status { get; set; }

    [Column("latitude")]
    public double? Latitude { get; set; }

    [Column("longitude")]
    public double? Longitude { get; set; }
}
