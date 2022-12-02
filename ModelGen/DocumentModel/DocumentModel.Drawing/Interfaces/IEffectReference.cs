namespace DocumentModel.Drawing;

/// <summary>
/// Defines the EffectReference Class.
/// </summary>
public interface IEffectReference // : DocumentModel.Drawing.IStyleReference
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
  public IStyleColor? StyleColor { get ; set; }
  
}
