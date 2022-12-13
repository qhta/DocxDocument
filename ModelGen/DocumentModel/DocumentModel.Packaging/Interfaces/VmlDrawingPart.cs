namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public interface VmlDrawingPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public DocumentModel.Packaging.LegacyDiagramTextPart? LegacyDiagramTextParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
