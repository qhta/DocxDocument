namespace DocumentModel.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public interface Anchor
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public Int64? X { get ; set; }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public Int64? Y { get ; set; }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public Int64? Z { get ; set; }
  
}
