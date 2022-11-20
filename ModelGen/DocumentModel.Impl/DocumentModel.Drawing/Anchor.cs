namespace DocumentModel.Drawing;

/// <summary>
/// Anchor Point.
/// </summary>
public class Anchor: IAnchor
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public long? X
  {
    get;
    set;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public long? Y
  {
    get;
    set;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public long? Z
  {
    get;
    set;
  }
  
}
