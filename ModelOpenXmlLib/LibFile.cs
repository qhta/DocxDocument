using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
  [Required]
  public required string FileName { get; set; }

}
