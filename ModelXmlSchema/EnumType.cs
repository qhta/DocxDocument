using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Simple enum type.
/// </summary>
public class EnumType: SimpleType
{
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

}
