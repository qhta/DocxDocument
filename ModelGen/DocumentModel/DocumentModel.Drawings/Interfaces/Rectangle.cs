namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public interface Rectangle
{
  /// <summary>
  /// Left
  /// </summary>
  public String? Left { get ; set; }
  
  /// <summary>
  /// Top
  /// </summary>
  public String? Top { get ; set; }
  
  /// <summary>
  /// Right
  /// </summary>
  public String? Right { get ; set; }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public String? Bottom { get ; set; }
  
}
