namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle")]
public interface DiagramStylePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.StyleDefinition? StyleDefinition { get ; set; }
  
}
