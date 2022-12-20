namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public partial interface Point2DType
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public Int64? X { get; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public Int64? Y { get; set; }
  
}
