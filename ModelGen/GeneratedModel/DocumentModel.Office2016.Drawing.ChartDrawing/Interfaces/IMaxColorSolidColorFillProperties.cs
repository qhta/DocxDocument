namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IMaxColorSolidColorFillProperties // : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
