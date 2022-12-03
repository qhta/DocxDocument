namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.SlidePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WorksheetPart), false, true)]
public interface DiagramDataPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.DataModelRoot? DataModelRoot { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public SlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public WorksheetPart? WorksheetParts { get ; set; }
  
}
