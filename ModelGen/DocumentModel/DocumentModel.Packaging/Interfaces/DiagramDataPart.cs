namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public interface DiagramDataPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelRoot? DataModelRoot { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.SlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public DocumentModel.Packaging.WorksheetPart? WorksheetParts { get ; set; }
  
}
