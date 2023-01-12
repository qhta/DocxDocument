namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public partial class ChartPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartColorStylePart>? ChartColorStyleParts { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartSpace? ChartSpace { get; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartStylePart>? ChartStyleParts { get; set; }
  
  public String? ContentType { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
