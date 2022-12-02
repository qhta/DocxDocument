namespace DocumentModel.Drawing;

/// <summary>
/// Accent 6.
/// </summary>
public interface IAccent6Color // : DocumentModel.Drawing.IColor2Type
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
