using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

/// <summary>
/// Namespace defined in DLL file.
/// </summary>
[Index(nameof(Name), IsUnique = true)]
[Index(nameof(Prefix), IsUnique = true)]
public class Namespace
{

  /// <summary>
  /// Unique identifier of the namespace.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// Full name of the namespace.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Collection of file-namespace relationships with this namespace.
  /// </summary>
  public virtual ICollection<FileNamespace> FileNamespaces { get; set; } = null!;

  ///// <summary>
  ///// Collection of namespaces defined in the file.
  ///// </summary>
  //public virtual ICollection<LibFile> Files => FileNamespaces.Select(item => item.File).ToList();

  ///// <summary>
  ///// Dictionary of files that define the namespace.
  ///// </summary>
  //public IDictionary<string, LibFile>? FilesDictionary => _FilesDictionary ??= Files.ToDictionary(item => item.FileName ?? "");

  //private IDictionary<string, LibFile>? _FilesDictionary;

  /// <summary>
  /// Collection of types defined in the namespace.
  /// </summary>
  public virtual ICollection<TypeDef> Types { get; set; } = null!;

  // Not mapped to the database, used for in-memory access
  [NotMapped]
  public Dictionary<string, TypeDef> TypesDictionary { get; set; } = null!;


}

