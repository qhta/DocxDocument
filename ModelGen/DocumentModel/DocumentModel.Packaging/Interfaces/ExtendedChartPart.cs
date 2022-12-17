namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public interface ExtendedChartPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartColorStylePart>? ChartColorStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ChartSpace? ChartSpace { get ; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartStylePart>? ChartStyleParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
