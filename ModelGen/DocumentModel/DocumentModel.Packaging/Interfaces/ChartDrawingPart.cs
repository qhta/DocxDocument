namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public interface ChartDrawingPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.UserShapes? UserShapes { get ; set; }
  
}
