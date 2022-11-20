namespace DocumentModel.Drawing;

/// <summary>
/// Fill To Rectangle.
/// </summary>
public class FillToRectangle: IFillToRectangle
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
