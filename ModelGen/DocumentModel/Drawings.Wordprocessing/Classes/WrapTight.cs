namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping.
/// </summary>
public partial class WrapTight
{
  
  /// <summary>
  ///   Text Wrapping Location
  /// </summary>
  [SchemaAttr("wrapText")]
  public DocumentModel.Drawings.Wordprocessing.WrapTextValues? WrapText { get; set; }
  
  
  /// <summary>
  ///   Distance From Test on Left Edge
  /// </summary>
  [SchemaAttr("distL")]
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  [SchemaAttr("distR")]
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   Tight Wrapping Extents Polygon.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.WrapPolygon? WrapPolygon { get; set; }
  
}
