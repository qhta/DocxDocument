using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;
/// <summary>
/// Attribute of the element.
/// </summary>
[Index(nameof(OwnerElementId), nameof(OrdNum), IsUnique = true)]
[Index(nameof(OwnerElementId), nameof(ShortName), IsUnique = true)]
[Index(nameof(OwnerElementId), IsUnique = false)]
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
  /// Unique identifier of the element which the attribute belongs to.
  /// </summary>
  public int OwnerElementId { get; set; }

  /// <summary>
  /// Ordinal number of the attribute in the owner element. Counted from 0.
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
  /// Namespace.
  /// </summary>
  [MaxLength(255)]
  public string? Namespace { get; set; }

  /// <summary>
  /// Text of the description in the second column of the attribute table.
  /// </summary>
  [MaxLength(Int32.MaxValue)]
  public string? DescriptionText { get; set; }

  /// <summary>
  /// Navigation property for the owner element.
  /// </summary>
  [Required]
  public Element OwnerElement { get; set; } = null!;
}

