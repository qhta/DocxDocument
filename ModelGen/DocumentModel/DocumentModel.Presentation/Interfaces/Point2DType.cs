namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public interface Point2DType // : System.Boolean
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public Int64? X { get ; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public Int64? Y { get ; set; }
  
}
