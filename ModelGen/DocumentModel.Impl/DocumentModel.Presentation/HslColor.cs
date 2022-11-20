namespace DocumentModel.Presentation;

/// <summary>
/// HSL.
/// </summary>
public class HslColor: IHslColor
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
  /// Lightness
  /// </summary>
  public int? Lightness
  {
    get;
    set;
  }
  
}
