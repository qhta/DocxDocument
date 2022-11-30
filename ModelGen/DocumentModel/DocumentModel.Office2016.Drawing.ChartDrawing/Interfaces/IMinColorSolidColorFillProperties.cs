namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public interface IMinColorSolidColorFillProperties // : DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlSolidColorFillPropertiesElement
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
}
