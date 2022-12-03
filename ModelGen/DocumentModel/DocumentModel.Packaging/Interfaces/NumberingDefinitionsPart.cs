namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface NumberingDefinitionsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Numbering? Numbering { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
