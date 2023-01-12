namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public partial class VmlDrawingPart
{
  public String? ContentType { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; set; }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.LegacyDiagramTextPart>? LegacyDiagramTextParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
