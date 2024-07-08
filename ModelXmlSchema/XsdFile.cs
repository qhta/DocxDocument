using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// SchemaFile represents an XSD file.
/// </summary>
[Index(nameof(FileName), IsUnique = true)]
public class XsdFile
{
  /// <summary>
  ///   Unique identifier for the SchemaFile.
  /// </summary>
  [Key] 
  public int Id { get; set; }

  /// <summary>
  ///  The name of the file (without path and extension).
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string FileName { get; set; }

  /// <summary>
  /// Unique identifier for the namespace defined in the file.
  /// </summary>
  public int? TargetNamespaceId { get; set; }

  /// <summary>
  /// Navigation property for the namespace defined in the file.
  /// </summary>
  public Namespace? TargetNamespace { get; set; }

  /// <summary>
  /// Collection of used namespaces in the file.
  /// </summary>
  public virtual ICollection<UsedNamespace> UsedNamespaces { get; set; } = null!;
}
