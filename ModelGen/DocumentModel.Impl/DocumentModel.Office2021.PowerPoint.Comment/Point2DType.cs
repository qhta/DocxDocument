namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public class Point2DType: IPoint2DType
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public long? X
  {
    get;
    set;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public long? Y
  {
    get;
    set;
  }
  
}
