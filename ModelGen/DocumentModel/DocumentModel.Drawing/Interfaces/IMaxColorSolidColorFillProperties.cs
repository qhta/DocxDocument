namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public interface IMaxColorSolidColorFillProperties // : DocumentModel.Drawing.IOpenXmlSolidColorFillPropertiesElement
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
