using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlLib;

/// <summary>
/// Represents an enumeration value.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerTypeId), nameof(OrdNum), IsUnique = false)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(ValueTypeId), IsUnique = false)]
[Index(nameof(Name), IsUnique = false)]
[Index(nameof(OrdNum), IsUnique = false)]
public class Property
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// The ordinal number of the declaration value.
  /// </summary>
  public int OrdNum { get; set; }

  /// <summary>
  /// The name of the property.
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
  /// Unique identifier of the value type.
  /// </summary>
  public int ValueTypeId { get; set; }

  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public TypeDef OwnerType { get; set; } = null!;

  /// <summary>
  /// Navigation property for the value type.
  /// </summary>
  public TypeDef ValueType { get; set; } = null!;

}
