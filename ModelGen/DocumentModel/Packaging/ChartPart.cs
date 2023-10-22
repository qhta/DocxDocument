namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartPart
/// </summary>
public partial class ChartPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartSpace? ChartSpace { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
