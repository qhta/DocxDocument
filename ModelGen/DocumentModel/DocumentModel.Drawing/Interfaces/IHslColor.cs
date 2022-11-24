namespace DocumentModel.Drawing;

/// <summary>
/// Hue, Saturation, Luminance Color Model.
/// </summary>
public interface IHslColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? HueValue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? SatValue { get ; set; }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public Int32? LumValue { get ; set; }
  
}
