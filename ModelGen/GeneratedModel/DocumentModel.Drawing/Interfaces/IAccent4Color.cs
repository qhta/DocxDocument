namespace DocumentModel.Drawing;

public interface IAccent4Color // : DocumentFormat.OpenXml.Drawing.Color2Type
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
