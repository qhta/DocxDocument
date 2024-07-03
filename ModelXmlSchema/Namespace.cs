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
  public virtual List<AttributeBase> Attributes { get; set; } = new();

  /// <summary>
  /// Dictionary of attributes defined directly in the namespace.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeBase> AttributesDictionary { get; set; } = new();

  /// <summary>
  /// Collection of attributes groups defined in the namespace.
  /// </summary>
  public virtual List<AttributeGroup> AttributeGroups { get; set; } = new();

  /// <summary>
  /// Dictionary of attributes defined directly in the namespace.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeGroup> AttributeGroupsDictionary { get; set; } = new();

}
