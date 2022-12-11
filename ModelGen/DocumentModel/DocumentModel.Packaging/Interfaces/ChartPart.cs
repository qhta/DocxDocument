namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public interface ChartPart
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
