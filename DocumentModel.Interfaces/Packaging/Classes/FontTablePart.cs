using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the FontTablePart
/// </summary>
public class FontTablePart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the FontParts of the FontTablePart
  /// </summary>
  public Collection<FontPart>? FontParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Fonts? Fonts { get; set; }
  public string? RelationshipType { get; set; }
}