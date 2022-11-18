namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
public interface IFontReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Identifier
  /// </summary>
  public FontCollectionIndex? Index { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
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
  public ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public IPresetColor? PresetColor { get ; set; }
  
}
