using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

[Index(nameof(OwnerFileId), IsUnique = false)]
[Index(nameof(ParentChapterId), IsUnique = false)]
[Index(nameof(NumStr), IsUnique = false)]
[Index(nameof(Heading), IsUnique = false)]
[Index(nameof(OwnerFileId), nameof(NumStr), IsUnique = true)]
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
  /// Specifies whether the chapter has subchapters.
  /// </summary>
  [Column(TypeName="bit")]
  public bool HasSubChapters { get; set; }

  /// <summary>
  /// Navigation property for the file that contains the chapter.
  /// </summary>
  public DocFile OwnerFile { get; set; } = null!;

  /// <summary>
  /// Navigation property for the parent chapter.
  /// </summary>
  public Chapter ParentChapter { get; set; } = null!;

  /// <summary>
  /// Navigation property for the collection of subchapters.
  /// </summary>
  public List<Chapter> SubChapters { get; set; } = null!;

  /// <summary>
  /// Dictionary of subchapters. Chapter Number is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Chapter> SubChaptersDictionary
  {
    get => _ListItemsDictionary ??= new Dictionary<string, Chapter>();
    set => _ListItemsDictionary = value;
  }
  private Dictionary<string, Chapter>? _ListItemsDictionary;
}
