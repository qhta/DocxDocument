namespace DocumentModel.Drawing;

/// <summary>
/// Tile Rectangle.
/// </summary>
public class TileRectangle: ITileRectangle
{
  /// <summary>
  /// Left Offset
  /// </summary>
  public int? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  public int? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  public int? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  public int? Bottom
  {
    get;
    set;
  }
  
}
