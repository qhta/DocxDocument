using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Simple type definition in a schema.
/// </summary>
public class SimpleType: TypeDef
{
  /// <summary>
  /// Fixed length of the hexBinary string (in bytes).
  /// </summary>
  public int? Length { get; set; }

  /// <summary>
  /// Minimum length of the string.
  /// </summary>
  public int? MinLength { get; set; }

  /// <summary>
  /// Maximum length of the string.
  /// </summary>
  public int? MaxLength { get; set; }

  /// <summary>
  /// Minimum inclusive value of the numeric type.
  /// </summary>
  [MaxLength(255)]
  public string? MinInclusive { get; set; }

  /// <summary>
  /// Maximum inclusive value of the numeric type.
  /// </summary>
  [MaxLength(255)]
  public string? MaxInclusive { get; set; }

  /// <summary>
  /// Minimum exclusive value of the numeric type.
  /// </summary>
  [MaxLength(255)]
  public string? MinExclusive { get; set; }

  /// <summary>
  /// Maximum exclusive value of the numeric type.
  /// </summary>
  [MaxLength(255)]
  public string? MaxExclusive { get; set; }

  /// <summary>
  /// Enumeration values for the simple type.
  /// </summary>
  public virtual ICollection<EnumValue> EnumValues { get; set; } = null!;

  /// <summary>
  /// Dictionary of enumeration values for the simple type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, EnumValue> EnumValuesDictionary
  {
    get => _EnumValuesDictionary ??= new Dictionary<string, EnumValue>();
    set => _EnumValuesDictionary = value;
  }

  private Dictionary<string, EnumValue>? _EnumValuesDictionary;

  /// <summary>
  /// Enumeration values for the simple type.
  /// </summary>
  public virtual ICollection<Pattern> Patterns { get; set; } = null!;

  /// <summary>
  /// Dictionary of patterns for the simple type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Pattern> PatternsDictionary
  {
    get => _PatternsDictionary ??= new Dictionary<string, Pattern>();
    set => _PatternsDictionary = value;
  }

  private Dictionary<string, Pattern>? _PatternsDictionary;
}
