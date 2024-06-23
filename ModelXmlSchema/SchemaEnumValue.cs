using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Enum value for simple types.
/// </summary>
public class SchemaEnumValue
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the enum value belongs to.
  /// </summary>
  public int SimpleTypeId { get; set; }

  /// <summary>
  /// String representation of the enum value.
  /// </summary>
  [MaxLength(255)]
  public string? EnumValueStr { get; set; }

  /// <summary>
  /// Numeric representation of the enum value.
  /// </summary>
  public int? EnumValueNum { get; set; }
}
