using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;
/// <summary>
/// Attribute of the element.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(OrdNum), IsUnique = true)]
[Index(nameof(OwnerTypeId), nameof(ShortName), IsUnique = true)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(OrdNum), IsUnique = false)]
[Index(nameof(ShortName), IsUnique = false)]
public class Attribute
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
  /// Ordinal number of the enum value in the owner type. Counted from 0.
  /// </summary>
  [Required]
  public int OrdNum { get; set; }

  /// <summary>
  /// String value the enum value.
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
  /// Text of the description in the secon column of the attribute table.
  /// </summary>
  [MaxLength(Int32.MaxValue)]
  public string? DescriptionText { get; set; }

  /// <summary>
  /// Navigation property for the owner element.
  /// </summary>
  [Required]
  public Element OwnerType { get; set; } = null!;
}

