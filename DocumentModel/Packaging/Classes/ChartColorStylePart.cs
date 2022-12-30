namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public partial class ChartColorStylePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ColorStyle? ColorStyle { get; set; }
  
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
