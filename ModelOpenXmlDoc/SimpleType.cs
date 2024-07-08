using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

/// <summary>
/// Simple type definition .
/// </summary>
[Index(nameof(OwnerChapterId), IsUnique = false)]
[Index(nameof(ShortName), nameof(OwnerChapterId), IsUnique = true)]
[Index(nameof(ShortName), IsUnique = false)]
[Index(nameof(LongName), nameof(OwnerChapterId), IsUnique = true)]
[Index(nameof(LongName), IsUnique = false)]
public class SimpleType
{
  /// <summary>
  /// Unique identifier for the type definition.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// ShortName of this type definition.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string ShortName { get; set; }

  /// <summary>
  /// LongName of this type definition.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string LongName { get; set; }

  /// <summary>
  /// Unique identifier of the chapter where the type is defined.
  /// </summary>
  public int OwnerChapterId { get; set; }

  /// <summary>
  /// Specifies if the simple type is an enumeration.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool IsEnum { get; set; }

  /// <summary>
  /// Navigation property for the namespace where this type is defined.
  /// </summary>
  [Required]
  public Chapter OwnerChapter { get; set; } = null!;

  /// <summary>
  /// Enumeration values for the simple type.
  /// </summary>
  public virtual ICollection<EnumValue> EnumValues { get; set; } = null!;

  /// <summary>
  /// Dictionary of enumeration values for the simple type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, EnumValue> EnumValuesDictionary
  {
    get => _EnumValuesDictionary ??= new Dictionary<string, EnumValue>();
    set => _EnumValuesDictionary = value;
  }
  private Dictionary<string, EnumValue>? _EnumValuesDictionary;

}