namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public partial interface DiagramDataPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelRoot? DataModelRoot { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts { get; }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WorksheetPart>? WorksheetParts { get; }
  
}
