using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDispatch.SharedModels.Entities;

[Table("events")]
public class Event
{
    [Key]
    [Required]
    [Column("id")]
    public required int Id { get; set; }

    [Column("record_id")]
    [MaxLength(255)]
    public Guid RecordId { get; set; }

    [Column("type")]
    [Required]
    [MaxLength(20)]
    public required string Type { get; set; } 

    [Column("latitude")]
    public double? Latitude { get; set; }

    [Column("longitude")]
    public double? Longitude { get; set; }
}
