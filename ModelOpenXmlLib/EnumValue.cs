using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlLib;

/// <summary>
/// Represents an enumeration value.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerTypeId), nameof(OrdNum), IsUnique = true)]
public class EnumValue
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// The ordinal number of the declaration.
  /// </summary>
  public int OrdNum { get; set; }

  /// <summary>
  /// The name of the enumeration value.
  /// </summary>
  [Required]
  [MaxLength(255)]
  public string Name { get; set; } = null!;

  /// <summary>
  /// Unique identifier of the owner type.
  /// </summary>
  [Required]
  public int OwnerTypeId { get; set; }

  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public TypeDef OwnerType { get; set; } = null!;
}
