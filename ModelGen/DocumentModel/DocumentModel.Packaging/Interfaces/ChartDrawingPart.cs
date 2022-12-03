namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes")]
[PartConstraint(typeof(DocumentModel.Packaging.ChartPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ExtendedChartPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface ChartDrawingPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.UserShapes? UserShapes { get ; set; }
  
}
