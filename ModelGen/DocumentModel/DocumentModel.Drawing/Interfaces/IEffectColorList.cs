namespace DocumentModel.Drawing;

/// <summary>
/// Effect Color List.
/// </summary>
public interface IEffectColorList // : DocumentModel.Drawing.IColorsType
{
  public Collection<IRgbColorModelPercentage>? RgbColorModelPercentages { get ; set; }
  
  public Collection<IRgbColorModelHex>? RgbColorModelHexs { get ; set; }
  
  public Collection<IHslColor>? HslColors { get ; set; }
  
  public Collection<ISystemColor>? SystemColors { get ; set; }
  
  public Collection<ISchemeColor>? SchemeColors { get ; set; }
  
  public Collection<IPresetColor>? PresetColors { get ; set; }
  
}
