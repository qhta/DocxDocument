namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
[ContentMime("application/vnd.ms-office.chartex+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2014/relationships/chartEx")]
[PartConstraint(typeof(DocumentModel.Packaging.ChartDrawingPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedPackagePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ThemeOverridePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartStylePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartColorStylePart), false, true)]
public interface ExtendedChartPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace? ChartSpace { get ; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartStylePart? ChartStyleParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
