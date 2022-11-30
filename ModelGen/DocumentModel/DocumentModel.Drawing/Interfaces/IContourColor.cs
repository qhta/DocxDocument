namespace DocumentModel.Drawing;

/// <summary>
/// Contour Color.
/// </summary>
public interface IContourColor // : DocumentModel.Drawing.IColorType
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
}
