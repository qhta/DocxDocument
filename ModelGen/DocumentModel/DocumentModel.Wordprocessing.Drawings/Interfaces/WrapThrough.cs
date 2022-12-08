namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Through Wrapping.
/// </summary>
public interface WrapThrough
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon { get ; set; }
  
}
