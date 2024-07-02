using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Namespace defined in schema XSD file.
/// </summary>
[Index(nameof(Url), IsUnique = true)]
[Index(nameof(Prefix), IsUnique = true)]
public class Namespace
{
  /// <summary>
  /// Unique identifier of the namespace.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// Url (long name) of the namespace.
  /// </summary>
  [MaxLength(255)]
  public required string Url { get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Collection of types defined in the namespace.
  /// </summary>
  public virtual ICollection<TypeDef> Types { get; set; } = null!;

  /// <summary>
  /// Dictionary of types defined in the namespace.
  /// </summary>
  [NotMapped]
  public Dictionary<string, TypeDef> TypesDictionary { get; set; } = null!;

  /// <summary>
  /// Collection of attributes defined directly in the namespace.
  /// </summary>
  public virtual ICollection<AttributeDef> GlobalAttributes { get; set; } = null!;

  /// <summary>
  /// Dictionary of attributes defined directly in the namespace.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeDef> AttributesDictionary { get; set; } = null!;

  /// <summary>
  /// Collection of attribute groups defined directly in the namespace.
  /// </summary>
  public virtual ICollection<AttributeGroup> GlobalAttributeGroups { get; set; } = null!;

  /// <summary>
  /// Dictionary of attribute groups defined directly in the namespace.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeGroup> AttributeGroupsDictionary { get; set; } = null!;
}
