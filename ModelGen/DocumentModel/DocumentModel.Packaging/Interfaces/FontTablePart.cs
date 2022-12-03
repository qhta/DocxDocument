namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable")]
[PartConstraint(typeof(DocumentModel.Packaging.FontPart), false, true)]
public interface FontTablePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public FontPart? FontParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Fonts? Fonts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
