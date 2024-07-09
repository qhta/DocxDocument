using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

/// <summary>
/// Element definition.
/// </summary>
[Index(nameof(OwnerChapterId), IsUnique = false)]
[Index(nameof(ShortName), nameof(OwnerChapterId), IsUnique = true)]
[Index(nameof(ShortName), IsUnique = false)]
[Index(nameof(LongName), nameof(OwnerChapterId), IsUnique = true)]
[Index(nameof(LongName), IsUnique = false)]
public class Element
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
  /// Specifies if the element has attributes.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool HasAttributes { get; set; }

  /// <summary>
  /// Text of the first paragraph of the chapter.
  /// </summary>
  [MaxLength(Int32.MaxValue)]
  public string? DescriptionText { get; set; }

  /// <summary>
  /// Unique identifier of the chapter where the type is defined.
  /// </summary>
  public int OwnerChapterId { get; set; }

  /// <summary>
  /// Navigation property for the namespace where this type is defined.
  /// </summary>
  [Required]
  public Chapter OwnerChapter { get; set; } = null!;

  /// <summary>
  /// Attributes for the simple type.
  /// </summary>
  public virtual ICollection<Attribute> Attributes { get; set; } = null!;

  /// <summary>
  /// Dictionary of attributes of the element.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Attribute> AttributesDictionary
  {
    get => _AttributesDictionary ??= new Dictionary<string, Attribute>();
    set => _AttributesDictionary = value;
  }
  private Dictionary<string, Attribute>? _AttributesDictionary;

}