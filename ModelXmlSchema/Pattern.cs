using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Pattern for simple types.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Value), IsUnique = true)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(Value), IsUnique = false)]
public class Pattern
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the pattern belongs to.
  /// </summary>
  public int OwnerTypeId { get; set; }

  /// <summary>
  /// Value of the pattern.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Value { get; set; }


  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public SimpleType OwnerType { get; set; } = null!;
}
