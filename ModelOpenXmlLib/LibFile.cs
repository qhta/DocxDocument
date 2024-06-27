using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ModelOpenXmlLib;

/// <summary>
/// LibFile represents a DLL file.
/// </summary>
[Index(nameof(FileName), IsUnique=true)]
public class LibFile
{
  /// <summary>
  ///   Unique identifier for the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  ///  The name of the file (without path and extension).
  /// </summary>
  [MaxLength(255)] public string? FileName { get; set; }

  /// <summary>
  /// Collection of namespaces defined in the file.
  /// </summary>
  public ICollection<FileNamespace> FileNamespaces { get; set; } = null!;

  ///// <summary>
  ///// Collection of namespaces defined in the file.
  ///// </summary>
  //public ICollection<LibNamespace> Namespaces { get } = null!;
}
