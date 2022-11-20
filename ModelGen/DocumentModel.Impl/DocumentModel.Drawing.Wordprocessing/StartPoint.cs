namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Wrapping Polygon Start.
/// </summary>
public class StartPoint: IStartPoint
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
