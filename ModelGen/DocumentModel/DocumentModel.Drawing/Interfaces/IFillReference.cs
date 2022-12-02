namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FillReference Class.
/// </summary>
public interface IFillReference // : DocumentModel.Drawing.IStyleReference
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
  public DocumentModel.Drawing.IStyleColor? StyleColor { get ; set; }
  
}
