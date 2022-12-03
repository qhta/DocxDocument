namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.vmlDrawing")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.LegacyDiagramTextPart), false, true)]
public interface VmlDrawingPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public LegacyDiagramTextPart? LegacyDiagramTextParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
