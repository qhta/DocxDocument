namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawingml.chart+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart")]
[PartConstraint(typeof(DocumentModel.Packaging.ChartDrawingPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedPackagePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ThemeOverridePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartStylePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartColorStylePart), false, true)]
public interface ChartPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace? ChartSpace { get ; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public ChartStylePart? ChartStyleParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
