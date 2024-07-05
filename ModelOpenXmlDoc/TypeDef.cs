using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

[Index(nameof(Name), IsUnique = false)]
[Index(nameof(NamespaceId), IsUnique = false)]
[Index(nameof(NamespaceId), nameof(Name), IsUnique = true)]
[Index(nameof(Kind), IsUnique = false)]
public class TypeDef
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// The name of the type.
  /// </summary>
  [MaxLength(255)]
  public string Name { get; set; } = null!;

  /// <summary>
  /// The kind of the type.
  /// </summary>
  public TypeKind Kind { get; set; }

  /// <summary>
  /// Specifies whether the type is abstract.
  /// </summary>
  public bool IsAbstract { get; set; }

  /// <summary>
  /// Unique identifier of the namespace containing the type.
  /// </summary>
  public int NamespaceId { get; set; }

  /// <summary>
  /// Navigation property for the namespace containing the type.
  /// </summary>
  public Namespace Namespace { get; set; } = null!;

  /// <summary>
  /// Unique identifier of the base type.
  /// </summary>
  public int? BaseTypeId { get; set; }

  /// <summary>
  /// Navigation property for the base type.
  /// </summary>
  public TypeDef? BaseType { get; set; }

  /// <summary>
  /// Navigation property for the derived types of the type.
  /// </summary>
  public ICollection<TypeDef>? DerivedTypes { get; set; }

  /// <summary>
  /// Navigation property for the enum values of the enum type.
  /// </summary>
  public virtual ICollection<EnumValue> EnumValues { get; set; } = null!;

  /// <summary>
  /// Dictionary of enum values of the enum type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, EnumValue> EnumValuesDictionary
  {
    get => _EnumValuesDictionary ??= new Dictionary<string, EnumValue>();
    set => _EnumValuesDictionary = value;
  }

  private Dictionary<string, EnumValue>? _EnumValuesDictionary;

  /// <summary>
  /// Navigation property for the properties of the complex type.
  /// </summary>
  public virtual ICollection<Property> Properties { get; set; } = null!;

  /// <summary>
  /// Dictionary of properties of the complex type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Property> PropertiesDictionary
  {
    get => _PropertiesDictionary ??= new Dictionary<string, Property>();
    set => _PropertiesDictionary = value;
  }

  private Dictionary<string, Property>? _PropertiesDictionary;
}
