namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Through Wrapping.
/// </summary>
public partial class WrapThrough
{
  
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   Wrapping Polygon.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.WrapPolygon? WrapPolygon { get; set; }
  
}
