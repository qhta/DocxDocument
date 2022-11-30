namespace DocumentModel.Drawing;

/// <summary>
/// Dark 2.
/// </summary>
public interface IDark2Color // : DocumentModel.Drawing.IColor2Type
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
}
