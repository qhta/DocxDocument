namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public interface IFontReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public FontCollectionIndexKind? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers { get ; set; }
  
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
  public IStyleColor? StyleColor { get ; set; }
  
}
