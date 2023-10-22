namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public partial class ExtendedChartPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ChartSpace? ChartSpace { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
