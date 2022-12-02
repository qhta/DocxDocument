namespace DocumentModel.Presentation;

/// <summary>
/// Background Style Reference.
/// </summary>
public interface IBackgroundStyleReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Matrix Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
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
