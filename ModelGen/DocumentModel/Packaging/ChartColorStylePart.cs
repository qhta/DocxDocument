namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartColorStylePart
/// </summary>
public partial class ChartColorStylePart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMDCS.ColorStyle? ColorStyle { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
