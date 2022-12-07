namespace DocumentModel.Drawings;

/// <summary>
/// Light 2.
/// </summary>
public interface Light2Color
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public HslColor? HslColor { get ; set; }
  
  public SystemColor? SystemColor { get ; set; }
  
  public PresetColor? PresetColor { get ; set; }
  
}
