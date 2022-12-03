namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors")]
public interface DiagramColorsPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorsDefinition? ColorsDefinition { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
