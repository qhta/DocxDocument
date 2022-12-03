namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface DiagramLayoutDefinitionPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.LayoutDefinition? LayoutDefinition { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
