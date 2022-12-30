namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public partial class ExtendedChartPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartColorStylePart>? ChartColorStyleParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ChartSpace? ChartSpace { get; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartStylePart>? ChartStyleParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
}
