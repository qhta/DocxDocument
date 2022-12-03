namespace DocumentModel.Drawings;

/// <summary>
/// Accent 6.
/// </summary>
public interface Accent6Color // : DocumentModel.Drawings.Color2Type
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public HslColor? HslColor { get ; set; }
  
  public SystemColor? SystemColor { get ; set; }
  
  public PresetColor? PresetColor { get ; set; }
  
}
