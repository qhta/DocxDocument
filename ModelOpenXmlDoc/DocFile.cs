using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

/// <summary>
/// Represents a DOCX file.
/// </summary>
[Index(nameof(FileName), IsUnique = true)]
public class DocFile
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

  /// <summary>
  /// Navigation property for the chapters in the file.
  /// </summary>
  public List<Chapter> Chapters { get; set; } = new();

  /// <summary>
  /// Dictionary of chapters in the file. Chapter Number is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Chapter> ChaptersDictionary { get; set; } = null!;

  /// <summary>
  /// Temporary storage for the Word document.
  /// </summary>
  [NotMapped]
  public WordprocessingDocument? Document { get; set; }

}
