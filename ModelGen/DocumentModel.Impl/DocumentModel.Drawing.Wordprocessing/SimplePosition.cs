namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Simple Positioning Coordinates.
/// </summary>
public class SimplePosition: ISimplePosition
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
