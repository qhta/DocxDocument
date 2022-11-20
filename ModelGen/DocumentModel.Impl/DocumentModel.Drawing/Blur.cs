namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public class Blur: IBlur
{
  /// <summary>
  /// Radius
  /// </summary>
  public long? Radius
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public bool? Grow
  {
    get;
    set;
  }
  
}
