namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MidColorSolidColorFillProperties Class.
/// </summary>
public interface IMidColorSolidColorFillProperties // : DocumentModel.Drawing.IOpenXmlSolidColorFillPropertiesElement
{
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
}
