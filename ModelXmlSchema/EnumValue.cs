using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Enum value for simple types.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Value), IsUnique = true)]
[Index(nameof(OwnerTypeId), nameof(OrdNum), IsUnique = false)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(Value), IsUnique = false)]
public class EnumValue
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] 
  public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the enum value belongs to.
  /// </summary>
  public int OwnerTypeId { get; set; }

  /// <summary>
  /// String representation of the enum value.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Value { get; set; }

  /// <summary>
  /// Ordinal number of enum value.Counted from 0.
  /// </summary>
  public int OrdNum { get; set; }

  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public SimpleType OwnerType { get; set; } = null!;
}
