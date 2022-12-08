namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public interface ExtendedChartPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace1? ChartSpace { get ; set; }
  
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
