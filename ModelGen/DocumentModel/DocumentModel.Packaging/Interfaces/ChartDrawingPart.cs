namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public partial interface ChartDrawingPart
{
  /// <summary>
  /// Gets the ChartPart of the ChartDrawingPart
  /// </summary>
  public DocumentModel.Packaging.ChartPart? ChartPart { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ExtendedChartPart of the ChartDrawingPart
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartPart { get; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.UserShapes? UserShapes { get; set; }
  
}
