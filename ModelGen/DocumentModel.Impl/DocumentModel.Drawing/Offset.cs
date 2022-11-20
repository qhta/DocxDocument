namespace DocumentModel.Drawing;

/// <summary>
/// Offset.
/// </summary>
public class Offset: IOffset
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
