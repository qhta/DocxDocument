namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the PosPoint3D Class.
/// </summary>
public class PosPoint3D: IPosPoint3D
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
