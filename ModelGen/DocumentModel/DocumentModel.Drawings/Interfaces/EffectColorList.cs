namespace DocumentModel.Drawings;

/// <summary>
/// Effect Color List.
/// </summary>
public interface EffectColorList // : DocumentModel.Drawings.ColorsType
{
  public Collection<RgbColorModelPercentage>? RgbColorModelPercentages { get ; set; }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs { get ; set; }
  
  public Collection<HslColor>? HslColors { get ; set; }
  
  public Collection<SystemColor>? SystemColors { get ; set; }
  
  public Collection<SchemeColor>? SchemeColors { get ; set; }
  
  public Collection<PresetColor>? PresetColors { get ; set; }
  
}
