using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ModelOpenXmlLib;

/// <summary>
/// LibFile represents a DLL file.
/// </summary>
[Index(nameof(FileName), IsUnique = true)]
public class LibFile
{
  /// <summary>
  ///   Unique identifier for the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  ///  The name of the file (without path and extension).
  /// </summary>
  [MaxLength(255)]
  public required string FileName { get; set; }

  ///// <summary>
  ///// Collection of file-namespace relationships with this file.
  ///// </summary>
  //public virtual ICollection<FileNamespace> FileNamespaces { get; set; } = null!;

  ///// <summary>
  ///// Collection of namespaces defined in the file.
  ///// </summary>
  //public virtual ICollection<Namespace> Namespaces => FileNamespaces.Select(item => item.Namespace).ToList();

  ///// <summary>
  ///// Navigation property for the properties that uses this type.
  ///// </summary>
  //public IDictionary<string, Namespace>? NamespacesDictionary => _NamespacesDictionary ??= Namespaces.ToDictionary(item => item.Name ?? "");

  ///// <summary>
  ///// Dictionary of namespaces defined in the file.
  ///// </summary>
  //private IDictionary<string, Namespace>? _NamespacesDictionary;
}
