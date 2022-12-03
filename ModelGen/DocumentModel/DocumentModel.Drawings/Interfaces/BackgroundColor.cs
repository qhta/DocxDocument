namespace DocumentModel.Drawings;

/// <summary>
/// Background color.
/// </summary>
public interface BackgroundColor // : DocumentModel.Drawings.ColorType
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public HslColor? HslColor { get ; set; }
  
  public SystemColor? SystemColor { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
  public PresetColor? PresetColor { get ; set; }
  
}
