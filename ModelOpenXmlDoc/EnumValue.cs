using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;
/// <summary>
/// Enum value for simple types.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(ShortName), IsUnique = true)]
[Index(nameof(OwnerTypeId), nameof(ShortName), IsUnique = false)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(ShortName), IsUnique = false)]
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
  /// Short name of the enum value.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string ShortName { get; set; }

  /// <summary>
  /// Long name of the enum value.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string LongName { get; set; }

  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public SimpleType OwnerType { get; set; } = null!;
}

