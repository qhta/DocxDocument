namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping.
/// </summary>
public partial class WrapTight
{
  
  /// <summary>
  ///   Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText { get; set; }
  
  
  /// <summary>
  ///   Distance From Test on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   Tight Wrapping Extents Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon { get; set; }
  
}
