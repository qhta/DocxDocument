using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlCmt;

/// <summary>
/// Represents a file with XML documentation.
/// </summary>
[Index(nameof(FileName), IsUnique = true)]
public class XmlFile
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
  /// Navigation property for the members in the file.
  /// </summary>
  public List<Member> Members { get; set; } = new();

  /// <summary>
  /// Dictionary of members in the file. Member FullName is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Member> MembersDictionary { get; set; } = null!;

  /// <summary>
  /// Temporary storage for the XML document.
  /// </summary>
  [NotMapped]
  public XDocument Document { get; set; } = null!;
}
