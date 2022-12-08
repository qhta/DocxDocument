namespace DocumentModel.Drawings;

/// <summary>
/// Duotone Effect.
/// </summary>
public interface Duotone
{
  public Collection<RgbColorModelPercentage>? RgbColorModelPercentages { get ; set; }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs { get ; set; }
  
  public Collection<HslColor>? HslColors { get ; set; }
  
  public Collection<SystemColor>? SystemColors { get ; set; }
  
  public Collection<SchemeColor>? SchemeColors { get ; set; }
  
  public Collection<PresetColor>? PresetColors { get ; set; }
  
}
