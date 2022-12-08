namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public interface ColorStyle
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public Collection<RgbColorModelPercentage>? RgbColorModelPercentages { get ; set; }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs { get ; set; }
  
  public Collection<HslColor>? HslColors { get ; set; }
  
  public Collection<SystemColor>? SystemColors { get ; set; }
  
  public Collection<SchemeColor>? SchemeColors { get ; set; }
  
  public Collection<PresetColor>? PresetColors { get ; set; }
  
  public Collection<ColorStyleVariation>? ColorStyleVariations { get ; set; }
  
  public OfficeArtExtensionList4? OfficeArtExtensionList { get ; set; }
  
}
