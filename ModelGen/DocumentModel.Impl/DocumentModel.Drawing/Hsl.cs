namespace DocumentModel.Drawing;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public class Hsl: IHsl
{
  /// <summary>
  /// Hue
  /// </summary>
  public int? Hue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public int? Saturation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public int? Luminance
  {
    get;
    set;
  }
  
}
