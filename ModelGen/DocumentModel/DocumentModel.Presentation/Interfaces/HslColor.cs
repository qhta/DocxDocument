namespace DocumentModel.Presentation;

/// <summary>
/// HSL.
/// </summary>
public interface HslColor // : System.Boolean
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? Saturation { get ; set; }
  
  /// <summary>
  /// Lightness
  /// </summary>
  public Int32? Lightness { get ; set; }
  
}
