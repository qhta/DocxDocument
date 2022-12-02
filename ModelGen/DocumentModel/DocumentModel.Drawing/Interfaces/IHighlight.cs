namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Highlight Class.
/// </summary>
public interface IHighlight // : DocumentModel.Drawing.IColorType
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
