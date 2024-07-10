using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

[Index(nameof(OwnerFileId), IsUnique = false)]
[Index(nameof(ParentChapterId), IsUnique = false)]
[Index(nameof(NumStr), IsUnique = false)]
[Index(nameof(Heading), IsUnique = false)]
[Index(nameof(OwnerFileId), nameof(NumStr), IsUnique = true)]
[Index(nameof(ParagraphId), IsUnique = true)]
public class Chapter
{
  /// <summary>
  ///   Unique identifier for the entity.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// The identifier of the file that contains the chapter.
  /// </summary>
  [Required]
  public int OwnerFileId { get; set; }

  /// <summary>
  /// The identifier of the chapter that contains the chapter.
  /// </summary>
  public int? ParentChapterId { get; set; }

  /// <summary>
  /// Ordinal number of the chapter in the owner file or parent chapter (counted from 1).
  /// </summary>
  [Required]
  public int OrdNum { get; set; }

  /// <summary>
  /// Number of the chapter.
  /// </summary>
  [MaxLength(50)]
  public required string NumStr { get; set; }

  /// <summary>
  ///  Heading of the chapter.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Heading { get; set; }

  /// <summary>
  /// Identifier of the paragraph in the Word document that contains the heading of the chapter.
  /// </summary>
  [MaxLength(8)]
  public string? ParagraphId { get; set; }

  /// <summary>
  /// Specifies whether the chapter has subchapters.
  /// </summary>
  [Column(TypeName="bit")]
  public bool HasSubChapters { get; set; }

  /// <summary>
  /// Specifies whether the chapter defines simple types.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool HasSimpleTypes { get; set; }

    /// <summary>
  /// Specifies whether the chapter defines elements.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool HasElements { get; set; }

  /// <summary>
  /// Navigation property for the file that contains the chapter.
  /// </summary>
  public DocFile OwnerFile { get; set; } = null!;

  /// <summary>
  /// Navigation property for the parent chapter.
  /// </summary>
  public Chapter? ParentChapter { get; set; } = null!;

  /// <summary>
  /// Navigation property for the collection of SubChapters.
  /// </summary>
  public List<Chapter> SubChapters { get; set; } = null!;

  /// <summary>
  /// Dictionary of subchapters. Chapter Number is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Chapter> SubChaptersDictionary
  {
    get => _SubChapters ??= new Dictionary<string, Chapter>();
    set => _SubChapters = value;
  }
  private Dictionary<string, Chapter>? _SubChapters;

  /// <summary>
  /// Navigation property for the collection of simple types defined in this chapter.
  /// </summary>
  public List<SimpleType> SimpleTypes { get; set; } = null!;

  /// <summary>
  /// Dictionary of simple types. Simple type ShortName is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, SimpleType> SimpleTypesDictionary
  {
    get => _SimpleTypes ??= new Dictionary<string, SimpleType>();
    set => _SimpleTypes = value;
  }
  private Dictionary<string, SimpleType>? _SimpleTypes;

  /// <summary>
  /// Navigation property for the collection of elements  defined in this chapter.
  /// </summary>
  public List<Element> Elements { get; set; } = null!;

  /// <summary>
  /// Dictionary of elements. Element ShortName is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Element> ElementsDictionary
  {
    get => _Elements ??= new Dictionary<string, Element>();
    set => _Elements = value;
  }
  private Dictionary<string, Element>? _Elements;

}
