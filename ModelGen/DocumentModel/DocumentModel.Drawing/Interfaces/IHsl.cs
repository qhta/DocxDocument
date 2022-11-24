namespace DocumentModel.Drawing;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public interface IHsl // : DocumentModel.ITypedOpenXmlLeafElement
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
  /// Luminance
  /// </summary>
  public Int32? Luminance { get ; set; }
  
}
