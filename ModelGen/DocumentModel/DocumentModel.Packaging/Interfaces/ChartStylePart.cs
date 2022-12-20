namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public partial interface ChartStylePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ChartStyle? ChartStyle { get; set; }
  
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
