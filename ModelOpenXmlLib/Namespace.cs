using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlLib;

/// <summary>
/// Namespace defined in DLL file.
/// </summary>
[Index(nameof(Name), IsUnique = true)]
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
  /// Collection of types defined in the namespace.
  /// </summary>
  public virtual ICollection<TypeDef> Types { get; set; } = null!;

  /// <summary>
  /// Dictionary of types defined in the namespace. Type Name is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, TypeDef> TypesDictionary { get; set; } = null!;


}

