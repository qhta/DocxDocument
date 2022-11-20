namespace DocumentModel.Drawing;

/// <summary>
/// Luminance.
/// </summary>
public class LuminanceEffect: ILuminanceEffect
{
  /// <summary>
  /// Brightness
  /// </summary>
  public int? Brightness
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public int? Contrast
  {
    get;
    set;
  }
  
}
