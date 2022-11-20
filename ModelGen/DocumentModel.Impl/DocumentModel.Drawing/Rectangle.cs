namespace DocumentModel.Drawing;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public class Rectangle: IRectangle
{
  /// <summary>
  /// Left
  /// </summary>
  public string? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public string? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public string? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public string? Bottom
  {
    get;
    set;
  }
  
}
