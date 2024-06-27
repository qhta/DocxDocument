using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlLib;

/// <summary>
/// Namespace defined in DLL file.
/// </summary>
[Index(nameof(Name), IsUnique=true)]
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
  public string? Name {get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Collection of files containing the namespace.
  /// </summary>
  public ICollection<FileNamespace> FileNamespaces { get; set; } = null!;

  /// <summary>
  /// Collection of types defined in the namespace.
  /// </summary>
  public ICollection<TypeDef> Types { get; set; } = null!;
}
