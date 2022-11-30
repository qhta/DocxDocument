namespace DocumentModel.Drawing;

/// <summary>
/// Inner Shadow Effect.
/// </summary>
public interface IInnerShadow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public System.Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// Distance
  /// </summary>
  public System.Int64? Distance { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public System.Int32? Direction { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
}
