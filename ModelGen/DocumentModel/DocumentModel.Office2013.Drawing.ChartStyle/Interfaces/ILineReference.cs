namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public interface ILineReference // : DocumentModel.Office2013.Drawing.ChartStyle.IStyleReference
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleColor? StyleColor { get ; set; }
  
}
