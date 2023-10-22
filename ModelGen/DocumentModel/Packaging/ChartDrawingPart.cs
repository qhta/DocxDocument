namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartDrawingPart
/// </summary>
public partial class ChartDrawingPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.UserShapes? UserShapes { get; set; }
  
}
