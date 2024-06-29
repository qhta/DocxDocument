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
  [Key] public int Id { get; set; }

  /// <summary>
  /// Url (long name) of the namespace.
  /// </summary>
  [MaxLength(255)]
  public required string Url {get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Collection of types defined in the namespace.
  /// </summary>
  public virtual ICollection<TypeDef> Types { get; set; } = null!;

  // Not mapped to the database, used for in-memory access
  [NotMapped] public Dictionary<string, TypeDef> TypesDictionary { get; set; } = null!;
}
