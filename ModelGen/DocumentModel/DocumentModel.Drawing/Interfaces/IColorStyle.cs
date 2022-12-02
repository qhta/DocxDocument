namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public interface IColorStyle // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public Collection<IRgbColorModelPercentage>? RgbColorModelPercentages { get ; set; }
  
  public Collection<IRgbColorModelHex>? RgbColorModelHexs { get ; set; }
  
  public Collection<IHslColor>? HslColors { get ; set; }
  
  public Collection<ISystemColor>? SystemColors { get ; set; }
  
  public Collection<ISchemeColor>? SchemeColors { get ; set; }
  
  public Collection<IPresetColor>? PresetColors { get ; set; }
  
  public Collection<IColorStyleVariation>? ColorStyleVariations { get ; set; }
  
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
